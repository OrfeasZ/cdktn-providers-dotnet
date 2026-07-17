using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurecr
{
    [JsiiInterface(nativeType: typeof(IServiceendpointAzurecrCredentials), fullyQualifiedName: "azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrCredentials")]
    public interface IServiceendpointAzurecrCredentials
    {
        /// <summary>The service principal id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#serviceprincipalid ServiceendpointAzurecr#serviceprincipalid}
        /// </remarks>
        [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
        string Serviceprincipalid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointAzurecrCredentials), fullyQualifiedName: "azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrCredentials")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The service principal id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#serviceprincipalid ServiceendpointAzurecr#serviceprincipalid}
            /// </remarks>
            [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
            public string Serviceprincipalid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
