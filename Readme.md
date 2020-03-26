# Covid-19 Project - Mapping international strain migration - implications for virulence and death ratio

## What am I trying to do?

* Everybody and their dog are creating mortality/cases prediction charts. Very cool and exciting but let's try something different.
* This web app is made in ASP.NET Core 3.1 Razor Pages and Google Geocharts.
* As you move the mouse pointer over each country you get some pop up information.
* As this pandemic is global, it can be helpful to visualise the information in the form of a world map.
* It shows the locations of each strain of the virus on a map along with some key information such as any differences in primary protein structure between two strains.
* For now it will compare against the original reference strain even though about 100 strains have been sequenced throughout the world.
* Protein sequence has been chosen because it will provide a quicker proof-of-concept than analysing the RNA sequences which is much more difficult
* It can be upgraded to include death rates as a measure of that strain's virulence.
* It can be upgraded to include viral RNA sequence homology information.

## Information to be displayed

![Map image](https://eempc.github.io/hosted_images/map.PNG)

* The information I am trying to display isn't so useful for the general public, it is more aimed at scientists who want to track the geolocation of strains
* The text box will need to display one of the strains that has been genetically sequenced there including the following information:
    * Country
    * Collection date
    * Number of different proteins from the reference strain
    * Ideally the method of collection, whether it was from waste water, a swab, etc

In future, it will display the following:

* RNA sequence homology differences
* Host species if it were to infect animals

But collating this information is difficult

## Techs

Doing this in C# and ASP.NET Core 3.1 because it's the one I know best.

## Overview of the steps

1. Obtain RNA/Protein sequence data from NCBI along with other data to do with the sequence
2. Compare the sequence data, I fear that this may require manual usage of BLAST especially for the RNA
3. Plot the data on a map like Azure Maps (only have a limited student account) or Google Geocharts (free)

## What's my expertise?

* I have a biology degree so terminology like ORF, IRES, bases, nucleotides, BLAST don't scare me. Kind of rusty though.
* I am trying to become a trainee software developer type person and was in the middle of job searching before Covid postponed my interviews.  Probably a blessing as I am terrible with interviews.
* I have not made anything collaboratively before so there is a good chance I will mess things up.

## Who do I need and what will they do?

### Someone to scrape the raw information from NCBI

* There are 100 complete sequence records
* Could download them one by one but that's not very efficient, so a Selenium solution might work
* I need the raw html text files that I can parse

### Parsing the html text then put the data into a SQL database

* There is a lot of junk information that needs to be sifted through.
* There are multiple sequence data, such as for the entire ORF1ab polyprotein and sub-proteins.
* The RNA sequence is a problem in that it is the CDS and that includes the 5' and 3' non-coding regions.

### Maps person (front end) - would need to know ASP Razor Pages, Entity Framework SQL, C#, LINQ, JS

* The current solution I see is for someone to have their own Razor Page (both the .cs and the .cshtml file).
* Google GeoCharts (free) or Azure Maps (I've only got a student account with limited funds)
* For the back end, you will need to know a bit of SQL/LINQ and Entity Framework
* For front end you will be combining Razor markup with JS to create some frankenstein hybrid code

Could I do this myself? Probably but I'd be pretty slow.

### Data Analysis - Protein sequence and RNA sequence

* I do not currently know if all the protein sequences are the same length. If they are, great, but if not I will need somebody to optimise the runtime of the comparison algorithm otherwise I will end up doing it badly with O(n!) or something.
* "Manual" method would be to use the BLAST alignment tool. "Manual" could mean Selenium if NCBI allows robots.

## Step 1 - Scraping the data

Step 1 is to obtain the data, this is from NCBI but I do not believe they have an API endpoint so the first step is to scrape the data.

## Step 2 - Parsing the html data to extract the useful information

This will involve a lot of regex fun (please kill me). I don't believe Selenium nor Beautiful Soup can help me here. But performance isn't necessary anyway as it's a one time operation.

Shove the data into a database. There are multiple strains per country though. For now just pick one.

Tables design could be:

Table 1 - Overview table (info from two documents unfortunately)
* Accession number (key, string)
* Accession version number (int)
* Country - some countries have their two letter codes e.g. USA, some have their full names e.g. Japan, so probably best to convert to the two letter code
* Region - some regions utilise a code, e.g. CA in the USA, some have full names e.g. Wuhan
* Collection date - we will be using YYYY-MM-DD format. some dates are precise to the day e.g. 2020-03-12, and some are precise to the month e.g. DEC-2019
* Collection date precise - yes/no (bool)
* Base length - int
* Completeness (a bool)
* Protein name, e.g. the polyprotein that is encoded entirely by the open reading frame orf1ab (string)
* The protein sequence (big string)
* protein length (int)
* RNA join sequence numbers


Will need some look up tables like geographic coordinates for regions and countries.

## Step 3 - Sequence homology analysis

Now that we have the data, what do we do with it.

So how do we do this eh? Count the number of each amino acid and run some comparisons? A basic alignment search might be better but this requires the protein sequences to have the same sizes. I would love to get my hands on the NCBI alignment algorithm.

For now everything will be compared to the reference strain. In future the user can select which strain to compare against.