using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    [JsiiInterface(nativeType: typeof(IMysqlBlueGreenDeploymentConfig), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentConfig")]
    public interface IMysqlBlueGreenDeploymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>channel_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#channel_details MysqlBlueGreenDeployment#channel_details}
        /// </remarks>
        [JsiiProperty(name: "channelDetails", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails\"}")]
        oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails ChannelDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#compartment_id MysqlBlueGreenDeployment#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#display_name MysqlBlueGreenDeployment#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#source_db_system_id MysqlBlueGreenDeployment#source_db_system_id}.</summary>
        [JsiiProperty(name: "sourceDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceDbSystemId
        {
            get;
        }

        /// <summary>target_db_system_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#target_db_system_details MysqlBlueGreenDeployment#target_db_system_details}
        /// </remarks>
        [JsiiProperty(name: "targetDbSystemDetails", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails\"}")]
        oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails TargetDbSystemDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#defined_tags MysqlBlueGreenDeployment#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to delete the target DB System when this Blue/Green deployment is deleted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#delete_target_db_system_on_delete MysqlBlueGreenDeployment#delete_target_db_system_on_delete}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteTargetDbSystemOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteTargetDbSystemOnDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#freeform_tags MysqlBlueGreenDeployment#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#id MysqlBlueGreenDeployment#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#switchover_trigger MysqlBlueGreenDeployment#switchover_trigger}.</summary>
        [JsiiProperty(name: "switchoverTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SwitchoverTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#timeouts MysqlBlueGreenDeployment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlBlueGreenDeploymentConfig), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>channel_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#channel_details MysqlBlueGreenDeployment#channel_details}
            /// </remarks>
            [JsiiProperty(name: "channelDetails", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails\"}")]
            public oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails ChannelDetails
            {
                get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#compartment_id MysqlBlueGreenDeployment#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#display_name MysqlBlueGreenDeployment#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#source_db_system_id MysqlBlueGreenDeployment#source_db_system_id}.</summary>
            [JsiiProperty(name: "sourceDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceDbSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>target_db_system_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#target_db_system_details MysqlBlueGreenDeployment#target_db_system_details}
            /// </remarks>
            [JsiiProperty(name: "targetDbSystemDetails", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails\"}")]
            public oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails TargetDbSystemDetails
            {
                get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#defined_tags MysqlBlueGreenDeployment#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Whether to delete the target DB System when this Blue/Green deployment is deleted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#delete_target_db_system_on_delete MysqlBlueGreenDeployment#delete_target_db_system_on_delete}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteTargetDbSystemOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteTargetDbSystemOnDelete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#freeform_tags MysqlBlueGreenDeployment#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#id MysqlBlueGreenDeployment#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#switchover_trigger MysqlBlueGreenDeployment#switchover_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "switchoverTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SwitchoverTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#timeouts MysqlBlueGreenDeployment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeouts\"}", isOptional: true)]
            public oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
