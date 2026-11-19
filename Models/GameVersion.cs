
namespace DBFZVersionManager.Models
{
    public class GameVersion
    {
        public string VersionNumber { get; set; }

        public string ManifestId { get; set; }

        public string? Description { get; set; }

        public GameVersion(string versionNumber, string manifestId, string? description = null)
        {
            VersionNumber = versionNumber;
            ManifestId = manifestId;
            Description = description;
        }
    }
}
