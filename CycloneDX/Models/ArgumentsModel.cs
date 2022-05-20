namespace CycloneDX.Models
{
    public class ArgumentsModel
    {
        public bool Version { get; set; }
        public string SolutionOrProjectFile { get; set; }
        public string OutputDirectory { get; set; }

        public string Json { get; set; }

        public bool? ExcludeDev { get; set; }

        public bool? ExcludeTestProjects { get; set; }

        public string NugetBaseUrl { get; set; }
        public string nugetBaseUrlUsername { get; set; }
        public string nugetBaseUrlUserPassword { get; set; }
        public bool isBaseUrlPasswordClearText { get; set; }
        public bool scanProjectReferences { get; set; }
        public bool noSerialNumber { get; set; }

        public string githubUsername { get; set; }

        public string githubToken { get; set; }

        public string githubBearerToken {get;set;}

        public bool disableGithubLicenses { get; set; }
        public bool disablePackageRestore { get; set; }
        public bool disableHashComputation { get; set; }
        public int dotnetCommandTimeout { get; set; }

        public string baseIntermediateOutputPath { get; set; }

        public string setName { get; set; }
        public string setVersion { get; set; }

        public Component.Classification setType { get; set; }
    }
}
