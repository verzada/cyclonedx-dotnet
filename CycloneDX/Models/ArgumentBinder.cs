using System.CommandLine;
using System.CommandLine.Binding;

namespace CycloneDX.Models
{
    public class ArgumentBinder : BinderBase<ArgumentsModel>
    {
        private readonly Option<bool> _versionOption;
        private readonly Option<string> _solutionOrProjectFileOption;
        private readonly Option<string> _outputDirectoryOption;
        private readonly Option<string> _jsonOption;
        private readonly Option<bool> _excludeDevOption;
        private readonly Option<bool> _excludeTestProjectsOption;
        private readonly Option<string> _nugetBaseUrl;
        private readonly Option<string> _nugetBaseUrlUsername;
        private readonly Option<string> _nugetBaseUrlUserPassword;
        private readonly Option<bool> _isBaseUrlPasswordClearText;
        private readonly Option<bool> _scanProjectReferences;
        private readonly Option<bool> _noSerialNumber;
        private readonly Option<string> _githubUsername;
        private readonly Option<string> _githubToken;
        private readonly Option<string> _githubBearerToken;
        private readonly Option<bool> _disableGithubLicenses;
        private readonly Option<bool> _disablePackageRestore;
        private readonly Option<bool> _disableHashComputation;
        private readonly Option<int> _dotnetCommandTimeout;
        private readonly Option<string> _baseIntermediateOutputPath;
        private readonly Option<string> _setName;
        private readonly Option<string> _setVersion;
        private readonly Option<Component.Classification> _setType;

        public ArgumentBinder(Option<bool> versionOption, Option<string> solutionOrProjectFileOption, Option<string> outputDirectoryOption, Option<string> jsonOption, Option<bool> excludeDevOption, Option<bool> excludeTestProjectsOption, Option<string> nugetBaseUrl, Option<string> nugetBaseUrlUsername, Option<string> nugetBaseUrlUserPassword, Option<bool> isBaseUrlPasswordClearText, Option<bool> scanProjectReferences, Option<bool> noSerialNumber, Option<string> githubUsername, Option<string> githubToken, Option<string> githubBearerToken, Option<bool> disableGithubLicenses, Option<bool> disablePackageRestore, Option<bool> disableHashComputation, Option<int> dotnetCommandTimeout, Option<string> baseIntermediateOutputPath, Option<string> setName, Option<string> setVersion, Option<Component.Classification> setType)
        {
            _versionOption = versionOption;
            _solutionOrProjectFileOption = solutionOrProjectFileOption;
            _outputDirectoryOption = outputDirectoryOption;
            _jsonOption = jsonOption;
            _excludeDevOption = excludeDevOption;
            _excludeTestProjectsOption = excludeTestProjectsOption;
            _nugetBaseUrl = nugetBaseUrl;
            _nugetBaseUrlUsername = nugetBaseUrlUsername;
            _nugetBaseUrlUserPassword = nugetBaseUrlUserPassword;
            _isBaseUrlPasswordClearText = isBaseUrlPasswordClearText;
            _scanProjectReferences = scanProjectReferences;
            _noSerialNumber = noSerialNumber;
            _githubUsername = githubUsername;
            _githubToken = githubToken;
            _githubBearerToken = githubBearerToken;
            _disableGithubLicenses = disableGithubLicenses;
            _disablePackageRestore = disablePackageRestore;
            _disableHashComputation = disableHashComputation;
            _dotnetCommandTimeout = dotnetCommandTimeout;
            _baseIntermediateOutputPath = baseIntermediateOutputPath;
            _setName = setName;
            _setVersion = setVersion;
            _setType = setType;
        }

        protected override ArgumentsModel GetBoundValue(BindingContext bindingContext) => new ArgumentsModel
        {
            Version = bindingContext.ParseResult.GetValueForOption(_versionOption),
            SolutionOrProjectFile = bindingContext.ParseResult.GetValueForOption(_solutionOrProjectFileOption),
            OutputDirectory = bindingContext.ParseResult.GetValueForOption(_outputDirectoryOption),
            Json = bindingContext.ParseResult.GetValueForOption(_jsonOption),
            ExcludeDev = bindingContext.ParseResult.GetValueForOption(_excludeDevOption),
            ExcludeTestProjects = bindingContext.ParseResult.GetValueForOption(_excludeTestProjectsOption),

            NugetBaseUrl = bindingContext.ParseResult.GetValueForOption(_nugetBaseUrl),
            nugetBaseUrlUsername = bindingContext.ParseResult.GetValueForOption(_nugetBaseUrlUsername),
            nugetBaseUrlUserPassword = bindingContext.ParseResult.GetValueForOption(_nugetBaseUrlUserPassword),
            isBaseUrlPasswordClearText = bindingContext.ParseResult.GetValueForOption(_isBaseUrlPasswordClearText),

            scanProjectReferences = bindingContext.ParseResult.GetValueForOption(_scanProjectReferences),
            noSerialNumber = bindingContext.ParseResult.GetValueForOption(_noSerialNumber),

            githubUsername = bindingContext.ParseResult.GetValueForOption(_githubUsername),
            githubToken = bindingContext.ParseResult.GetValueForOption(_githubToken),
            githubBearerToken = bindingContext.ParseResult.GetValueForOption(_githubBearerToken),
            disableGithubLicenses = bindingContext.ParseResult.GetValueForOption(_disableGithubLicenses),

            disablePackageRestore = bindingContext.ParseResult.GetValueForOption(_disablePackageRestore),
            disableHashComputation = bindingContext.ParseResult.GetValueForOption(_disableHashComputation),
            dotnetCommandTimeout = bindingContext.ParseResult.GetValueForOption(_dotnetCommandTimeout),
            baseIntermediateOutputPath = bindingContext.ParseResult.GetValueForOption(_baseIntermediateOutputPath),
            setName = bindingContext.ParseResult.GetValueForOption(_setName),
            setVersion = bindingContext.ParseResult.GetValueForOption(_setVersion),
            setType = bindingContext.ParseResult.GetValueForOption(_setType)
        };
    }
}
