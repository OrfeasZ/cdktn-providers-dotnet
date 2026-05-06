using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiAwrHubAwrSnapshot
{
    [JsiiInterface(nativeType: typeof(IDataOciOpsiAwrHubAwrSnapshotConfig), fullyQualifiedName: "oci.dataOciOpsiAwrHubAwrSnapshot.DataOciOpsiAwrHubAwrSnapshotConfig")]
    public interface IDataOciOpsiAwrHubAwrSnapshotConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#awr_hub_id DataOciOpsiAwrHubAwrSnapshot#awr_hub_id}.</summary>
        [JsiiProperty(name: "awrHubId", typeJson: "{\"primitive\":\"string\"}")]
        string AwrHubId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#awr_source_database_identifier DataOciOpsiAwrHubAwrSnapshot#awr_source_database_identifier}.</summary>
        [JsiiProperty(name: "awrSourceDatabaseIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string AwrSourceDatabaseIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#id DataOciOpsiAwrHubAwrSnapshot#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#time_greater_than_or_equal_to DataOciOpsiAwrHubAwrSnapshot#time_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "timeGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#time_less_than_or_equal_to DataOciOpsiAwrHubAwrSnapshot#time_less_than_or_equal_to}.</summary>
        [JsiiProperty(name: "timeLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeLessThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOpsiAwrHubAwrSnapshotConfig), fullyQualifiedName: "oci.dataOciOpsiAwrHubAwrSnapshot.DataOciOpsiAwrHubAwrSnapshotConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOpsiAwrHubAwrSnapshot.IDataOciOpsiAwrHubAwrSnapshotConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#awr_hub_id DataOciOpsiAwrHubAwrSnapshot#awr_hub_id}.</summary>
            [JsiiProperty(name: "awrHubId", typeJson: "{\"primitive\":\"string\"}")]
            public string AwrHubId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#awr_source_database_identifier DataOciOpsiAwrHubAwrSnapshot#awr_source_database_identifier}.</summary>
            [JsiiProperty(name: "awrSourceDatabaseIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string AwrSourceDatabaseIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#id DataOciOpsiAwrHubAwrSnapshot#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#time_greater_than_or_equal_to DataOciOpsiAwrHubAwrSnapshot#time_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_awr_hub_awr_snapshot#time_less_than_or_equal_to DataOciOpsiAwrHubAwrSnapshot#time_less_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeLessThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
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
