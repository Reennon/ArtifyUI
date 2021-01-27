using System;

namespace UIArtify.Services
{
    public class NavState
    {
        private Boolean _active;

        public Boolean Active
        {
            get => _active;
            set
            {
                _active = value;
                NotifyStateChanged();
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}