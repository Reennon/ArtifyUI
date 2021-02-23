using System;

namespace UIArtify.Configurations
{
    public sealed class Api
    {
        public String ApiRoute { get; set; }
        public String ApiPrefix { get; set; }
        public String RunBuild
        {
            get => ApiRoute + ApiPrefix + _runBuild;
            set => _runBuild = value;
        }
        public String UpdateExecutable
        {
            get => ApiRoute + ApiPrefix + _updateExecutable;
            set => _updateExecutable = value;
        }
        public String Build
        {
            get => ApiRoute + ApiPrefix + _build;
            set => _build = value;
        }
        public String Error
        {
            get => ApiRoute + ApiPrefix + _error;
            set => _error = value;
        }
        public String SwitchPreference
        {
            get => ApiRoute + ApiPrefix + _switchPreference;
            set => _switchPreference = value;
        }
        public String LoadPreference
        {
            get => ApiRoute + ApiPrefix + _loadPreference;
            set => _loadPreference = value;
        }
        public String UploadPreference
        {
            get => ApiRoute + ApiPrefix + _uploadPreference;
            set => _uploadPreference = value;
        }
        public String UploadResource
        {
            get => ApiRoute + ApiPrefix + _uploadResource;
            set => _uploadResource = value;
        }
        public String Login
        {
            get => ApiRoute + ApiPrefix + _login;
            set => _login = value;
        }
        public String Logout
        {
            get => ApiRoute + ApiPrefix + _logout;
            set => _logout = value;
        }
        public String Signup
        {
            get => ApiRoute + ApiPrefix + _signup;
            set => _signup = value;
        }
        public String Smoke
        {
            get => ApiRoute + ApiPrefix + _smoke;
            set => _smoke = value;
        }
        public String Script
        {
            get => ApiRoute + ApiPrefix + _script;
            set => _script = value;
        } 
        public String ScriptJson
        {
            get => ApiRoute + ApiPrefix + _scriptJson;
            set => _scriptJson = value;
        }
        
        public String Output{
            get => ApiRoute + ApiPrefix + _output;
            set => _output = value;
        }
        
        public String Tree{
            get => ApiRoute + ApiPrefix + _tree;
            set => _tree = value;
        }
        
        
        private String _script;
        private String _smoke;
        private String _signup;
        private String _logout;
        private String _login;
        private String _runBuild;
        private String _updateExecutable;
        private String _build;
        private String _error;
        private String _switchPreference;
        private String _loadPreference;
        private String _uploadPreference;
        private String _uploadResource;
        private String _scriptJson;
        private String _output;
        private String _tree;
    }
}