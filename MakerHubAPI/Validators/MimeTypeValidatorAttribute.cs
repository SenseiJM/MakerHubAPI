using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MakerHubAPI.Validators {
    public class MimeTypeValidatorAttribute : ValidationAttribute {

        public string[] mimeTypes;

        public MimeTypeValidatorAttribute(params string[] mimeTypes) {

            this.mimeTypes = mimeTypes;

        }

        public override bool IsValid(object value) {

            if (value == null) {
                return true;
            }

            if (mimeTypes.Contains(value)) {

                return true;

            } else {
                return false;
            }

        }



    }
}
