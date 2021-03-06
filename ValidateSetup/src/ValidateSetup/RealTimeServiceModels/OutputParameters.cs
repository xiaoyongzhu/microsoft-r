// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateRealTimeService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OutputParameters
    {
        /// <summary>
        /// Initializes a new instance of the OutputParameters class.
        /// </summary>
        public OutputParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OutputParameters class.
        /// </summary>
        /// <param name="outputData">data.frame</param>
        public OutputParameters(object outputData = default(object))
        {
            OutputData = outputData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data.frame
        /// </summary>
        [JsonProperty(PropertyName = "outputData")]
        public object OutputData { get; set; }

    }
}
