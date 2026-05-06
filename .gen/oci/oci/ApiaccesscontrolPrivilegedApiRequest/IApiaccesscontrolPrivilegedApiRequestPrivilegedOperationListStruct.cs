using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiRequest
{
    [JsiiInterface(nativeType: typeof(IApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct")]
    public interface IApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#api_name ApiaccesscontrolPrivilegedApiRequest#api_name}.</summary>
        [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#attribute_names ApiaccesscontrolPrivilegedApiRequest#attribute_names}.</summary>
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#api_name ApiaccesscontrolPrivilegedApiRequest#api_name}.</summary>
            [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#attribute_names ApiaccesscontrolPrivilegedApiRequest#attribute_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
