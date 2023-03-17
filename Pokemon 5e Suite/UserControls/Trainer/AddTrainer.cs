using Pokemon_5e_Suite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pokemon_5e_Suite.Models.TrainerModel;

namespace Pokemon_5e_Suite.UserControls.Trainer
{
    public partial class AddTrainer : UserControl
    {
        TrainerModel newTrainer;

        public AddTrainer()
        {
            newTrainer = new TrainerModel();
            InitializeComponent();
        }

        // button handler to create a key item struct and display it in the listview
        private void OnKeyItemAddButton_Click(object sender, EventArgs e)
        {

        }

        // button handler to create a consumable struct and display it in the listview
        private void OnConsumableAddButton_Click(object sender, EventArgs e)
        {

        }

        // button handler to create a feat struct and display it in the listview
        private void OnFeatAddButton_Click(object sender, EventArgs e)
        {

        }

        // button handler to clear all editable trainer fields
        private void OnTrainerClearButton_Click(object sender, EventArgs e)
        {

        }

        // button handler to save all editable fields to an object and then write to a local XML file
        private void OnTrainerSaveButton_Click(object sender, EventArgs e)
        {
            // save form data to Trainer object
            

            // serialize created object to local XML file
        }

        // function for clearing all of the UserControl controls
        public void ClearAllControls()
        {
            // reset trainer model to clear all attributes assigned up to this point
            newTrainer = new TrainerModel();

            Controls.Clear(); // add in as per VS2022 recommendation. test?
        }

        // function for saving all editable fields to an object
        public void SaveTrainer()
        {

        }

    }
}
