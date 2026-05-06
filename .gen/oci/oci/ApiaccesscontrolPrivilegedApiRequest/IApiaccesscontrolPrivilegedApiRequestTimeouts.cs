using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiRequest
{
    [JsiiInterface(nativeType: typeof(IApiaccesscontrolPrivilegedApiRequestTimeouts), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestTimeouts")]
    public interface IApiaccesscontrolPrivilegedApiRequestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#create ApiaccesscontrolPrivilegedApiRequest#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#delete ApiaccesscontrolPrivilegedApiRequest#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#update ApiaccesscontrolPrivilegedApiRequest#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiaccesscontrolPrivilegedApiRequestTimeouts), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#create ApiaccesscontrolPrivilegedApiRequest#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#delete ApiaccesscontrolPrivilegedApiRequest#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#update ApiaccesscontrolPrivilegedApiRequest#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
