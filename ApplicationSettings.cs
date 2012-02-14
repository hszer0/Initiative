using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Initiative
{
    public class ApplicationSettings
    {
        private bool appSettingsChanged;
        private DataSet dsParticipants;
        private Point pntLastLocation;
        private Size szeLastSize;

        public ApplicationSettings()
        {
            
        }

        public DataSet Participants
        {
            get { return dsParticipants; }
            set
            {
                if (value != dsParticipants)
                {
                    dsParticipants = value;
                    appSettingsChanged = true;
                }
            }
        }

        public Point FormLocation
        {
            get { return pntLastLocation; }
            set
            {
                if (value != pntLastLocation)
                {
                    pntLastLocation = value;
                    appSettingsChanged = true;
                }
            }
        }

        public Size FormSize
        {
            get { return szeLastSize; }
            set
            {
                if (value != szeLastSize)
                {
                    szeLastSize = value;
                    appSettingsChanged = true;
                }
            }
        }
 

        // Serializes the class to the config file
        // if any of the settings have changed.
        public bool SaveAppSettings()
        {
            if (this.appSettingsChanged)
            {
                StreamWriter myWriter = null;
                XmlSerializer mySerializer = null;
                try
                {
                     //Create an XmlSerializer for the 
                     //ApplicationSettings type.
                    mySerializer = new XmlSerializer(
                      typeof(ApplicationSettings));
                    myWriter =
                      new StreamWriter(Application.StartupPath
                      + @"\InitiativeSettings.config", false);
                     //Serialize this instance of the ApplicationSettings 
                     //class to the config file.
                    mySerializer.Serialize(myWriter, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // If the FileStream is open, close it.
                    if (myWriter != null)
                    {
                        myWriter.Close();
                    }
                }
            }

            return appSettingsChanged;
        }

        // Deserializes the class from the config file.
        public bool LoadAppSettings()
        {
            XmlSerializer mySerializer = null;
            FileStream myFileStream = null;
            bool fileExists = false;

            try
            {
                // Create an XmlSerializer for the ApplicationSettings type.
                mySerializer = new XmlSerializer(typeof(ApplicationSettings));
                FileInfo fi = new FileInfo(Application.StartupPath
                   + @"\InitiativeSettings.config");
                // If the config file exists, open it.
                if (fi.Exists)
                {
                    myFileStream = fi.OpenRead();
                    // Create a new instance of the ApplicationSettings by
                    // deserializing the config file.
                    ApplicationSettings myAppSettings =
                      (ApplicationSettings)mySerializer.Deserialize(
                       myFileStream);
                    // Assign the property values to this instance of 
                    // the ApplicationSettings class.
                    this.pntLastLocation = myAppSettings.FormLocation;
                    this.dsParticipants = myAppSettings.Participants;
                    this.szeLastSize = myAppSettings.FormSize;
                    fileExists = true;
                }
                else
                {
                    this.SaveAppSettings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // If the FileStream is open, close it.
                if (myFileStream != null)
                {
                    myFileStream.Close();
                }
            }

            if (this.szeLastSize == null || this.szeLastSize.Height < 200 || this.szeLastSize.Width < 200)
            {
                this.szeLastSize = new Size(600, 400);
            }

            if (this.dsParticipants == null)
            {
                DataTable dtPart = new DataTable("Participants");
                DataColumn name = new DataColumn("Name", typeof(string));
                DataColumn[] keys = new DataColumn[1];
                keys[0] = name;
                dtPart.Columns.Add(name);
                dtPart.Columns.Add("Type", typeof(string));
                dtPart.Columns.Add("Init", typeof(int));
                dtPart.Columns.Add("Dex", typeof(int));
                dtPart.PrimaryKey = keys;
                this.dsParticipants = new DataSet();
                this.dsParticipants.Tables.Add(dtPart);
            }

            return fileExists;
        }
    }
}
