// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AllowedAttributes Description
    /// </summary>
    public partial class AllowedAttributes
    {
        /// <summary>
        /// Initializes a new instance of the AllowedAttributes class.
        /// </summary>
        public AllowedAttributes()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AllowedAttributes class.
        /// </summary>
        /// <param name="aliased">Range Description</param>
        public AllowedAttributes(double aliased = default(double))
        {
            Aliased = aliased;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets range Description
        /// </summary>
        [JsonProperty(PropertyName = "Aliased")]
        public double Aliased { get; set; }

    }
}
