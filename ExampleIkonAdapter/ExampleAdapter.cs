using System;
using System.AddIn;
using IkonApplianceAdapterAddInCommon;

namespace IkonAdapterExample
{
    [AddIn("Example Adapter", Version = "1.0.0.0", Publisher = "YOURNAME - YOURCOMPANY", Description = "Example Adapter Description")]
    public class ExampleAdapter : IkonApplianceAdapterBase
    {
        /// <summary>
        /// Main entry point for Addin Pipeline.
        /// </summary>
        /// <param name="passDataObject">PassDataObject</param>
        /// <returns>Success Message</returns>
        public override string ProcessPassData(PassDataObject passDataObject)
        {
            throw new NotImplementedException("This Adapter has not been implemented yet.");
        }
    }
}
