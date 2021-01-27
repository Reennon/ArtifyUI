using System;

namespace UIArtify.Configurations
{
    public sealed class Api
    {
        public String ApiRoute { get; set; }

        private String _runBuild;

        public String RunBuild
        {
            get => ApiRoute + _runBuild;
            set => _runBuild = value;
        }

        private String _updateExecutable;

        public String UpdateExecutable
        {
            get => ApiRoute + _updateExecutable;
            set => _updateExecutable = value;
        }

        private String _buildResource;

        public String BuildResource
        {
            get => ApiRoute + _buildResource;
            set => _buildResource = value;
        }

        private String _error;

        public String Error
        {
            get => ApiRoute + _error;
            set => _error = value;
        }

        private String _switchPreference;

        public String SwitchPreference
        {
            get => ApiRoute + _switchPreference;
            set => _switchPreference = value;
        }

        private String _loadPreference;

        public String LoadPreference
        {
            get => ApiRoute + _loadPreference;
            set => _loadPreference = value;
        }

        private String _uploadPreference;

        public String UploadPreference
        {
            get => ApiRoute + _uploadPreference;
            set => _uploadPreference = value;
        }

        private String _uploadResource;

        public String UploadResource
        {
            get => ApiRoute + _uploadResource;
            set => _uploadResource = value;
        }

        private String _login;

        public String Login
        {
            get => ApiRoute + _login;
            set => _login = value;
        }

        private String _logout;

        public String Logout
        {
            get => ApiRoute + _logout;
            set => _logout = value;
        }

        private String _signup;

        public String Signup
        {
            get => ApiRoute + _signup;
            set => _signup = value;
        }
    }
}