
using System.Windows;
using DBFZVersionManager.Models;
using System.Collections.Generic;

namespace DBFZVersionManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadTestVersions();
        }

        private void LoadTestVersions()
        {
            List<GameVersion> versions = new List<GameVersion>
            {
                new GameVersion("1.01", "PLACEHOLDER", "Launch Version"),
                new GameVersion("1.31", "PLACEHOLDER", "Rollback Beta"),
                new GameVersion("1.42", "PLACEHOLDER"),
                new GameVersion("1.50", "PLACEHOLDER", "Current Version")
            };

            foreach (GameVersion version in versions)
            {
                string displayText = version.VersionNumber;

                if (!string.IsNullOrWhiteSpace(version.Description))
                {
                    displayText += " - " + version.Description;
                }

                VersionSelector.Items.Add(displayText);
            }
        }
    }
}
