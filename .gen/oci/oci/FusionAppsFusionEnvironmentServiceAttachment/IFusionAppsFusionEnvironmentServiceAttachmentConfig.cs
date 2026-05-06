using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentServiceAttachment
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentServiceAttachmentConfig), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentServiceAttachment.FusionAppsFusionEnvironmentServiceAttachmentConfig")]
    public interface IFusionAppsFusionEnvironmentServiceAttachmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#fusion_environment_id FusionAppsFusionEnvironmentServiceAttachment#fusion_environment_id}.</summary>
        [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        string FusionEnvironmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#service_instance_id FusionAppsFusionEnvironmentServiceAttachment#service_instance_id}.</summary>
        [JsiiProperty(name: "serviceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#service_instance_type FusionAppsFusionEnvironmentServiceAttachment#service_instance_type}.</summary>
        [JsiiProperty(name: "serviceInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceInstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#defined_tags FusionAppsFusionEnvironmentServiceAttachment#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#id FusionAppsFusionEnvironmentServiceAttachment#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#timeouts FusionAppsFusionEnvironmentServiceAttachment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentServiceAttachment.FusionAppsFusionEnvironmentServiceAttachmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FusionAppsFusionEnvironmentServiceAttachment.IFusionAppsFusionEnvironmentServiceAttachmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentServiceAttachmentConfig), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentServiceAttachment.FusionAppsFusionEnvironmentServiceAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironmentServiceAttachment.IFusionAppsFusionEnvironmentServiceAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#fusion_environment_id FusionAppsFusionEnvironmentServiceAttachment#fusion_environment_id}.</summary>
            [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string FusionEnvironmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#service_instance_id FusionAppsFusionEnvironmentServiceAttachment#service_instance_id}.</summary>
            [JsiiProperty(name: "serviceInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#service_instance_type FusionAppsFusionEnvironmentServiceAttachment#service_instance_type}.</summary>
            [JsiiProperty(name: "serviceInstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceInstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#defined_tags FusionAppsFusionEnvironmentServiceAttachment#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#id FusionAppsFusionEnvironmentServiceAttachment#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_service_attachment#timeouts FusionAppsFusionEnvironmentServiceAttachment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentServiceAttachment.FusionAppsFusionEnvironmentServiceAttachmentTimeouts\"}", isOptional: true)]
            public oci.FusionAppsFusionEnvironmentServiceAttachment.IFusionAppsFusionEnvironmentServiceAttachmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.FusionAppsFusionEnvironmentServiceAttachment.IFusionAppsFusionEnvironmentServiceAttachmentTimeouts?>();
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
