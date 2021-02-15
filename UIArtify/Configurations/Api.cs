using System;

namespace UIArtify.Configurations
{
    public sealed class Api
    {
        public String ApiRoute { get; set; }
        
        public String ApiPrefix { get; set; }

        private String _runBuild;

        public String RunBuild
        {
            get => ApiRoute + ApiPrefix + _runBuild;
            set => _runBuild = value;
        }

        private String _updateExecutable;

        public String UpdateExecutable
        {
            get => ApiRoute + ApiPrefix + _updateExecutable;
            set => _updateExecutable = value;
        }

        private String _build;

        public String Build
        {
            get => ApiRoute + ApiPrefix + _build;
            set => _build = value;
        }

        private String _error;

        public String Error
        {
            get => ApiRoute + ApiPrefix + _error;
            set => _error = value;
        }

        private String _switchPreference;

        public String SwitchPreference
        {
            get => ApiRoute + ApiPrefix + _switchPreference;
            set => _switchPreference = value;
        }

        private String _loadPreference;

        public String LoadPreference
        {
            get => ApiRoute + ApiPrefix + _loadPreference;
            set => _loadPreference = value;
        }

        private String _uploadPreference;

        public String UploadPreference
        {
            get => ApiRoute + ApiPrefix + _uploadPreference;
            set => _uploadPreference = value;
        }

        private String _uploadResource;

        public String UploadResource
        {
            get => ApiRoute + ApiPrefix + _uploadResource;
            set => _uploadResource = value;
        }

        private String _login;

        public String Login
        {
            get => ApiRoute + ApiPrefix + _login;
            set => _login = value;
        }

        private String _logout;

        public String Logout
        {
            get => ApiRoute + ApiPrefix + _logout;
            set => _logout = value;
        }

        private String _signup;

        public String Signup
        {
            get => ApiRoute + ApiPrefix + _signup;
            set => _signup = value;
        }
        private String _smoke;

        public String Smoke
        {
            get => ApiRoute + ApiPrefix + _smoke;
            set => _smoke = value;
        }
    }
}