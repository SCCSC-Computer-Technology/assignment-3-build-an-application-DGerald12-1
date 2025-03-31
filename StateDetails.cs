using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DGerald_CPT_206_A80S_Lab_3_States_DB
{
    public partial class StateDetails : Form
    {
        public StateDetails()
        {
            InitializeComponent();
        }

        public StateDetails(object stateID, string stateName, object population, string capital, string stateFlower, string stateBird, string stateColors, string largestCities, object stateMedian, object computerJobs)
        {
            InitializeComponent();           

            stateIdTextBox.Text = stateID.ToString();
            nameTextBox.Text = stateName;
            populationTextBox.Text = population.ToString();
            capitalTextBox.Text = capital;
            state_FlowerTextBox.Text = stateFlower;
            state_BirdTextBox.Text = stateBird;
            state_ColorsTextBox.Text = stateColors;
            largest_CitiesTextBox.Text = largestCities;
            state_MedianTextBox.Text = stateMedian.ToString();
            computer_Related_JobsTextBox.Text = computerJobs.ToString();

           
            stateNameLabel.Visible = true;
            stateNameLabel.Text = nameTextBox.Text;
            infoLabel.Visible = true;
            infoLabel.Text = "*Click on the state name for more info*";
            //stateNameLabel.Visible = false;

        }               

        

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
           // MessageBox.Show("You've FINALLY got it right!");
        }

        private void stateNameLabel_Click(object sender, EventArgs e)
        {
            if (stateNameLabel.Text == nameTextBox.Text)
            {

               
                FunFact(); // invoke the method to display state flag and fun fact


            }                
        }

       

        private void FunFact()
        {
            stateFlagPictureBox.Visible = true;

            if (stateNameLabel.Text == "Alabama")
            {

                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\ALABAMA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThere's a store in Alabama that sells unclaimed baggage: Unclaimed Baggae Center located in " +
                     "Scottsboro, Alabama, is organized into 10 departments, including books, womenswear, menswear, electronics, " +
                     "and fine jewelry.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Alaska")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\ALASKA.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe northernmost city in the US, Utqiaġvik, Alaska, experiences periods of " +
                    "uninterrupted daylight and darkness. the city experiences 85 days of the state's famous \"midnight sun,\" as " +
                    "the sun stays above the horizon during this period from May to early August.\r\n\r\nConversely, the city also " +
                    "experiences a \"polar night,\" where there's essentially no sunlight for two months during the winter.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Arizona")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\ARIZONA.jpg");
                pictureGroupBox.BackColor = ColorTranslator.FromHtml("#ffde1a");
                detailsGroupBox.BackColor = ColorTranslator.FromHtml("#ffde1a");
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe bola tie is the official state neckwear of Arizona. This was established" +
                    "in 1973.";
                funFactLabel.BackColor = ColorTranslator.FromHtml("#ffde1a");
            }
            else if (stateNameLabel.Text == "Arkansas")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\ARKANSAS.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe most expensive diamond ever discovered in the US was found in Arkansas." +
                    "\nThe 8.52-carat diamond was found at the Crater of Diamonds State Park in Murfreesboro, Arkansas, in 2015 by " +
                    "Bobbie Oskarson, and she named it after her niece. The Esperanza Diamond was fashioned into a necklace and is " +
                    "worth an estimated $1 million.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "California")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\CALIFORNIA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe state is home to over 100 ghost towns. \nOne of the most famous ghost towns in " +
                    "California is Bodie. The gold-mining town was once home to 10,000 people, but was fully abandoned by 1942, with some " +
                    "people seemingly having packed their belongings mid-meal.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Colorado")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\COLORADO.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThere has never been a US president or vice president born in Colorado.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Connecticut")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\CONNECTICUT.jpg");
                pictureGroupBox.BackColor = Color.Yellow;
                detailsGroupBox.BackColor = Color.Yellow;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe first phone book in the US was printed in New Haven in 1878. The first " +
                    "phone book didn't actually list any phone numbers. Instead, it was a piece of cardboard with a list of 50 " +
                    "people and businesses who had phones.";
                funFactLabel.BackColor = Color.Yellow;
            }
            else if (stateNameLabel.Text == "Delaware")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\DELAWARE.jpg");
                pictureGroupBox.BackColor = ColorTranslator.FromHtml("#f0dc82"); // Colonial Blue
                detailsGroupBox.BackColor = ColorTranslator.FromHtml("#f0dc82"); // Colonial Blue
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nChickens outnumber people 200-to-1 in Delaware. \nPer the USDA, Delaware is " +
                    "home to over 200 million chickens. Meanwhile, the US Census Bureau reported that as of 2023, the state has a " +
                    "population of about 1 million people.";
                funFactLabel.BackColor = ColorTranslator.FromHtml("#f0dc82"); // Colonial Blue
            }
            else if (stateNameLabel.Text == "Florida")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\FLORIDA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nDisney World in Orlando is a no-fly zone. The popular theme park is one of " +
                    "several no-fly zones in the US. Per the FAA, it received permanent no-fly zone status in 2014.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Georgia")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\GEORGIA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThere were four other state capitals before Atlanta. Savannah, Augusta, " +
                    "Louisville, and Milledgeville are the state's previous capitals.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Hawaii")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\HAWAII.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nHawaii has the highest life expectancy out of any state. In 2020, the CDC " +
                    "reported that life expectancy in Hawaii was 80.7 years.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Idaho")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\IDAHO.jpg");
                pictureGroupBox.BackColor = Color.Yellow;
                detailsGroupBox.BackColor = Color.Yellow;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nAt 7,993 feet deep, the Snake River in Hells Canyon is the deepest river " +
                    "gorge in North America. This gorge is 2,000 feet deeper than the Grand Canyon.";
                funFactLabel.BackColor = Color.Yellow;
            }
            else if (stateNameLabel.Text == "Illinois")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\ILLINOIS.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe Prairie State should be re-nicknamed the Pumpkin State — it produces more " +
                    "pumpkins annually than any other state in the US. The USDA reported that Illinois produced 634 million pounds " +
                    "of pumpkins in 2022.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Indiana")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\INDIANA.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nIt's illegal to catch a fish with your bare hands. You also can't catch a fish " +
                    "with firearms, a crossbow, or dynamite";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Iowa")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\IOWA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nPigs outnumber the human population in Iowa by about 7-to-1. In 2022, the " +
                    "USDA reported that Iowa had 23.4 million hogs and pigs";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Kansas")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\KANSAS.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nNatural gas deposits in the state are some of the most helium-rich in the world.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Kentucky")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\KENTUCKY.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThere are more barrels of bourbon than people in Kentucky. As of 2022, there " +
                    "are 11.4 million barrels of bourbon in the state. That's about 2.5 barrels of bourbon per person.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Louisiana")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\LOUISIANA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nMilk is the official state drink. It's been the official drink of choice " +
                    "for Louisiana since 1983.";
                funFactLabel.BackColor = Color.White;
            }
            
            else if (stateNameLabel.Text == "Maine")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MAINE.jpg");
                pictureGroupBox.BackColor = Color.Yellow;
                detailsGroupBox.BackColor = Color.Yellow;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe state has its own desert in Freeport. Per the location's website, the " +
                    "Desert of Maine is home to 20 acres of sand dunes with history that dates back to the 1800s.";
                funFactLabel.BackColor = Color.Yellow;
            }
            else if (stateNameLabel.Text == "Maryland")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MARYLAND.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe first Ouija board was invented in Maryland. The Library of Congress " +
                    "reported that the spooky board was first manufactured in Baltimore in 1890 for \"supernatural communication.\"";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Massachusetts")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MASSACHUSETTS.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nBasketball was invented in Springfield. James Naismith created the 13 original " +
                    "rules of basketball in Springfield, Massachusetts. The first public game was played in 1892.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Michigan")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MICHIGAN.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nNo matter where you are in the state, you'll never be more than 85 miles from one of " +
                    "the Great Lakes. The state is shaped by four of the five Great Lakes, including Lake Michigan, Huron, Superior, " +
                    "and Erie.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Minnesota")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MINNESOTA.jpg");
                pictureGroupBox.BackColor = ColorTranslator.FromHtml("#ADD8E6");
                detailsGroupBox.BackColor = ColorTranslator.FromHtml("#ADD8E6");
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nMinnesota has the highest proportion of public golf courses. Per the National " +
                    "Golf Foundation, 90% of the state's 477 golf courses are open to the public. That's 17% higher than the national " +
                    "average.";
                funFactLabel.BackColor = ColorTranslator.FromHtml("#ADD8E6");
            }
            else if (stateNameLabel.Text == "Mississippi")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MISSISSIPPI.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nBarq's Root Beer was invented in Biloxi in 1898.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Missouri")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MISSOURI.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe first successful parachute jump from a moving plane (what we now call " +
                    "skydiving) was completed in Missouri.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Montana")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\MONTANA.jpg");
                pictureGroupBox.BackColor = ColorTranslator.FromHtml("#ffff32");
                detailsGroupBox.BackColor = ColorTranslator.FromHtml("#ffff32");
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nIn 1972, Loma, Montana, set the world record for the largest temperature increase " +
                    "in 24 hours. From January 14 to January 15, 1972, the temperature in Loma, Montana, rose 103 degrees Fahrenheit " +
                    "from -54 degrees Fahrenheit to 49 degrees Fahrenheit, the National Centers for Environmental Information reported.";
                funFactLabel.BackColor = ColorTranslator.FromHtml("#ffff32");
            }
            else if (stateNameLabel.Text == "Nebraska")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NEBRASKA.jpg");
                pictureGroupBox.BackColor = Color.Yellow;
                detailsGroupBox.BackColor = Color.Yellow;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nKool-Aid is the official state soft drink of Nebraska. The popular beverage powder " +
                    "was invented in Hastings, Nebraska, by Edwin Perkins in 1927. It has been the state's official soft drink since 1998.";
                funFactLabel.BackColor = Color.Yellow;
            }
            else if (stateNameLabel.Text == "Nevada")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NEVADA.png");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nNearly half of all the wild horses in the US are in Nevada.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "New Hampshire")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NEW HAMPSHIRE.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nAlan B. Shepard Jr., the first American to travel into space, was from New Hampshire.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "New Jersey")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NEW JERSEY.jpg");
                pictureGroupBox.BackColor = ColorTranslator.FromHtml("#f0dc82");
                detailsGroupBox.BackColor = ColorTranslator.FromHtml("#f0dc82");
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nDuring the Revolutionary War, more battles were fought in New Jersey than in " +
                    "any other colony.";
                funFactLabel.BackColor = ColorTranslator.FromHtml("#f0dc82");
            }
            else if (stateNameLabel.Text == "New Mexico")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NEW MEXICO.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nSanta Fe, New Mexico, is 7,000 feet above sea level, making it the state " +
                    "capital with the highest elevation in the country.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "New York")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NEW YORK.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;               ;
                funFactLabel.Text = "Fun Fact:  \n\nNew York was the first state to require license plates on cars. New York " +
                    "Governor Benjamin Odell Jr. signed the bill into law on April 25, 1901.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "North Carolina")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NORTH CAROLINA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;                
                funFactLabel.Text = "Fun Fact:  \n\nNorth Carolina produces the most sweet potatoes out of all the 50 states. The state " +
                    "has held the No. 1 spot since 1971 and produces about 60% of the country's supply, the North Carolina History " +
                    "Project reported.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "North Dakota")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\NORTH DAKOTA.jpg");
                pictureGroupBox.BackColor = Color.Gold;                
                detailsGroupBox.BackColor = Color.Gold;                
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nRugby, North Dakota, is home to the geographical center of North America. " +
                    "The monument was created in 1932.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Ohio")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\OHIO.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;                
                funFactLabel.Text = "Fun Fact:  \n\nOhio has the only state flag in the US that isn't rectangular.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Oklahoma")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\OKLAHOMA.jpg");
                pictureGroupBox.BackColor = Color.White;                
                detailsGroupBox.BackColor = Color.White;                
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThere are more man-made lakes in Oklahoma than in any other state. Many of " +
                    "the man-made lakes were made to help with issues like flood control, water supply, and hydroelectric power";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Oregon")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\OREGON.jpg");
                pictureGroupBox.BackColor = Color.Yellow;
                detailsGroupBox.BackColor = Color.Yellow;
                funFactLabel.Visible = true;               
                funFactLabel.Text = "Fun Fact:  \n\nPortland, Oregon, has more breweries than almost any other city in the world.";
                funFactLabel.BackColor = Color.Yellow;
            }
            else if (stateNameLabel.Text == "Pennsylvania")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\PENNSYLVANIA.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe first public zoo in the US opened in 1874 in Philadelphia. The Philadelphia " +
                    "Zoo opened on July 1, 1874, and continues to operate today, housing more than 1,700 rare and endangered animals, " +
                    "per its website.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Rhode Island")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\RHODE ISLAND.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe first polo club in the US was founded in Rhode Island in 1876 BY James " +
                    "Gordon Bennett Jr., the Westchester Polo Club, which is based in Newport, Rhode Island.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "South Carolina")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\SOUTH CAROLINA.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nTGeorgia may be well known for its peaches, but South Carolina actually produces " +
                    "more of the fruit annually. Per the state's Department of Agriculture, South Carolina produces \"more than three " +
                    "times the amount\" of peaches than Georgia.\r\n\r\nIt calls itself \"the tastier peach state.\"";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "South Dakota")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\SOUTH DAKOTA.jpg");
                pictureGroupBox.BackColor = Color.Yellow;
                detailsGroupBox.BackColor = Color.Yellow;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nUntil its closure in 2002, the Homestake Mine in Lead, South Dakota, was the " +
                    "largest and deepest gold mine in North America. It is reported that the gold mine produced over 40 million " +
                    "ounces of gold during its 125 plus years of operation.";
                funFactLabel.BackColor = Color.Yellow;
            }
            else if (stateNameLabel.Text == "Tennessee")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\TENNESSEE.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe Great Smoky Mountains National Park is the most visited National Park in the US." +
                    "In 2023, more than 13 million people visited Great Smoky Mountains National Park, National Geographic reported. " +
                    "Grand Canyon National Park, which is No. 2, only attracted 4.7 million visitors.";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Texas")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\TEXAS.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nDr Pepper was invented in Texas in 1885 by pharmacist Charles Alderton in " +
                    "Waco, Texas..";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Utah")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\UTAH.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nUtah is the only state where every county includes a part of a national forest. " +
                    "The state is home to six national forests: Dixie, Fishlake, Manti-LaSal, Uinta, Ashley, and Wasatch.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Vermont")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\VERMONT.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nVermont produced 2.05 million gallons of maple syrup in 2023, more than any other " +
                    "state. The state has only been outproduced twice: in 1918 and 1926, per the USDA";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Virgina")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\VIRGINIA.jpg");
                pictureGroupBox.BackColor = ColorTranslator.FromHtml("#9fc5e8");
                detailsGroupBox.BackColor = ColorTranslator.FromHtml("#9fc5e8");
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe first college fraternity was founded in the College of William & Mary in 1776." +
                    "The secret society was named Phi Beta Kappa.";
                funFactLabel.BackColor = ColorTranslator.FromHtml("#9fc5e8");
            }
            else if (stateNameLabel.Text == "Washington")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\WASHINGTON.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nWashington produces six out of every 10 apples consumed in the US. Per the " +
                    "Washington Apple Commission, the state harvests 10-12 billion apples annually. The apple is also the official " +
                    "state fruit.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "West Virgina")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\WEST VIRGINIA.jpg");
                pictureGroupBox.BackColor = Color.Gold;
                detailsGroupBox.BackColor = Color.Gold;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nWest Virginia's name was almost \"Kanawha.\" Per the state, the name was discussed " +
                    "at a delegate convention in 1861 before \"West Virginia\" was officially selected. West Virginia became the " +
                    "country's 35th state in 1863.";
                funFactLabel.BackColor = Color.Gold;
            }
            else if (stateNameLabel.Text == "Wisconsin")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\WISCONSIN.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nThe QWERTY keyboard was invented in Wisconsin by Christopher Latham Sholes " +
                    "and Carlos Glidden, and their typewriter debuted in 1874. ";
                funFactLabel.BackColor = Color.White;
            }
            else if (stateNameLabel.Text == "Wyoming")
            {
                stateFlagPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\WYOMING.jpg");
                pictureGroupBox.BackColor = Color.White;
                detailsGroupBox.BackColor = Color.White;
                funFactLabel.Visible = true;
                funFactLabel.Text = "Fun Fact:  \n\nWyoming was the first state in the country to have a female governor. Nellie " +
                    "Tayloe Ross was elected in 1925 after her husband died before finishing his term as governor, the National Governors " +
                    "Association reported. She went on to become vice chair of the Democratic National Committee and served two terms as " +
                    "director of the US Mint under President Franklin D. Roosevelt.";
                funFactLabel.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Invalid entry--no state listed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
                
        }
    }

}


