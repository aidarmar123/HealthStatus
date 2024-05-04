using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStatus.Models
{
    public partial class Emoji
    {
        public Emoji(ImageSource source)
        {
            Source = source;
        }

        public ImageSource Source { get; set; }
    }
}
