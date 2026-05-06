using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveTypeGroupGroupedSensitiveType
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig), fullyQualifiedName: "oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig")]
    public interface IDataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#sensitive_type_group_id DataSafeSensitiveTypeGroupGroupedSensitiveType#sensitive_type_group_id}.</summary>
        [JsiiProperty(name: "sensitiveTypeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string SensitiveTypeGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#id DataSafeSensitiveTypeGroupGroupedSensitiveType#id}.</summary>
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

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#patch_operations DataSafeSensitiveTypeGroupGroupedSensitiveType#patch_operations}
        /// </remarks>
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PatchOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#timeouts DataSafeSensitiveTypeGroupGroupedSensitiveType#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig), fullyQualifiedName: "oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#sensitive_type_group_id DataSafeSensitiveTypeGroupGroupedSensitiveType#sensitive_type_group_id}.</summary>
            [JsiiProperty(name: "sensitiveTypeGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string SensitiveTypeGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#id DataSafeSensitiveTypeGroupGroupedSensitiveType#id}.</summary>
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

            /// <summary>patch_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#patch_operations DataSafeSensitiveTypeGroupGroupedSensitiveType#patch_operations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PatchOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#timeouts DataSafeSensitiveTypeGroupGroupedSensitiveType#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts\"}", isOptional: true)]
            public oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts?>();
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
