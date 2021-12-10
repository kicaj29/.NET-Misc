using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class SettingsCollection
    {
        public SettingsCollection()
        {
            Settings = Array.Empty<Setting>();
        }

        private SettingsCollection(bool isReadonly):this()
        {
            this._isReadOnly = isReadonly;
        }

        static SettingsCollection()
        {
            Empty = new SettingsCollection(true);
        }

        private readonly bool _isReadOnly;
        public static SettingsCollection Empty;
        private Setting[] _settings { get; set; }
        public Setting[] Settings
        {
            get { return _settings; }
            set
            {
                if (_isReadOnly)
                    throw new InvalidOperationException("Cannot modify readonly settings.");
                _settings = value;
            }
        }
    }
}
