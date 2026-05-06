using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SecurityAttributeSecurityAttribute
{
    [JsiiInterface(nativeType: typeof(ISecurityAttributeSecurityAttributeConfig), fullyQualifiedName: "oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeConfig")]
    public interface ISecurityAttributeSecurityAttributeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#description SecurityAttributeSecurityAttribute#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#name SecurityAttributeSecurityAttribute#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#security_attribute_namespace_id SecurityAttributeSecurityAttribute#security_attribute_namespace_id}.</summary>
        [JsiiProperty(name: "securityAttributeNamespaceId", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityAttributeNamespaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#id SecurityAttributeSecurityAttribute#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#is_retired SecurityAttributeSecurityAttribute#is_retired}.</summary>
        [JsiiProperty(name: "isRetired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRetired
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#timeouts SecurityAttributeSecurityAttribute#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>validator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#validator SecurityAttributeSecurityAttribute#validator}
        /// </remarks>
        [JsiiProperty(name: "validator", typeJson: "{\"fqn\":\"oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeValidator\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeValidator? Validator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityAttributeSecurityAttributeConfig), fullyQualifiedName: "oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#description SecurityAttributeSecurityAttribute#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#name SecurityAttributeSecurityAttribute#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#security_attribute_namespace_id SecurityAttributeSecurityAttribute#security_attribute_namespace_id}.</summary>
            [JsiiProperty(name: "securityAttributeNamespaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityAttributeNamespaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#id SecurityAttributeSecurityAttribute#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#is_retired SecurityAttributeSecurityAttribute#is_retired}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isRetired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRetired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#timeouts SecurityAttributeSecurityAttribute#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeTimeouts\"}", isOptional: true)]
            public oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeTimeouts?>();
            }

            /// <summary>validator block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/security_attribute_security_attribute#validator SecurityAttributeSecurityAttribute#validator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validator", typeJson: "{\"fqn\":\"oci.securityAttributeSecurityAttribute.SecurityAttributeSecurityAttributeValidator\"}", isOptional: true)]
            public oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeValidator? Validator
            {
                get => GetInstanceProperty<oci.SecurityAttributeSecurityAttribute.ISecurityAttributeSecurityAttributeValidator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
