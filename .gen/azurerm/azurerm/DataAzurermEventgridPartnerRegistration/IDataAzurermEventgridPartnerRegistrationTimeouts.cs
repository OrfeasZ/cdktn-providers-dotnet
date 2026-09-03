using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridPartnerRegistration
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventgridPartnerRegistrationTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridPartnerRegistration.DataAzurermEventgridPartnerRegistrationTimeouts")]
    public interface IDataAzurermEventgridPartnerRegistrationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/eventgrid_partner_registration#read DataAzurermEventgridPartnerRegistration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventgridPartnerRegistrationTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridPartnerRegistration.DataAzurermEventgridPartnerRegistrationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventgridPartnerRegistration.IDataAzurermEventgridPartnerRegistrationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/eventgrid_partner_registration#read DataAzurermEventgridPartnerRegistration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
