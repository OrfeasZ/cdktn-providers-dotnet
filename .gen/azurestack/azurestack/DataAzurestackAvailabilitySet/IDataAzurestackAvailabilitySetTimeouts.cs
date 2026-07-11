using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackAvailabilitySet
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackAvailabilitySetTimeouts), fullyQualifiedName: "azurestack.dataAzurestackAvailabilitySet.DataAzurestackAvailabilitySetTimeouts")]
    public interface IDataAzurestackAvailabilitySetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/availability_set#read DataAzurestackAvailabilitySet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackAvailabilitySetTimeouts), fullyQualifiedName: "azurestack.dataAzurestackAvailabilitySet.DataAzurestackAvailabilitySetTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackAvailabilitySet.IDataAzurestackAvailabilitySetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/availability_set#read DataAzurestackAvailabilitySet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
