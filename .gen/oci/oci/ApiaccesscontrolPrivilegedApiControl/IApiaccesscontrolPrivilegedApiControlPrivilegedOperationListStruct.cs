using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiControl
{
    [JsiiInterface(nativeType: typeof(IApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiControl.ApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct")]
    public interface IApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#api_name ApiaccesscontrolPrivilegedApiControl#api_name}.</summary>
        [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#attribute_names ApiaccesscontrolPrivilegedApiControl#attribute_names}.</summary>
        [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AttributeNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#entity_type ApiaccesscontrolPrivilegedApiControl#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntityType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiControl.ApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.ApiaccesscontrolPrivilegedApiControl.IApiaccesscontrolPrivilegedApiControlPrivilegedOperationListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#api_name ApiaccesscontrolPrivilegedApiControl#api_name}.</summary>
            [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#attribute_names ApiaccesscontrolPrivilegedApiControl#attribute_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AttributeNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_control#entity_type ApiaccesscontrolPrivilegedApiControl#entity_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntityType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
