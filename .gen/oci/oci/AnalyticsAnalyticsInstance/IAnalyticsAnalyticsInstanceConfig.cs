using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    [JsiiInterface(nativeType: typeof(IAnalyticsAnalyticsInstanceConfig), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceConfig")]
    public interface IAnalyticsAnalyticsInstanceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity AnalyticsAnalyticsInstance#capacity}
        /// </remarks>
        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacity\"}")]
        oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity Capacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#compartment_id AnalyticsAnalyticsInstance#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#feature_set AnalyticsAnalyticsInstance#feature_set}.</summary>
        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        string FeatureSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#license_type AnalyticsAnalyticsInstance#license_type}.</summary>
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        string LicenseType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#name AnalyticsAnalyticsInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#admin_user AnalyticsAnalyticsInstance#admin_user}.</summary>
        [JsiiProperty(name: "adminUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#defined_tags AnalyticsAnalyticsInstance#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#description AnalyticsAnalyticsInstance#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#domain_id AnalyticsAnalyticsInstance#domain_id}.</summary>
        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#email_notification AnalyticsAnalyticsInstance#email_notification}.</summary>
        [JsiiProperty(name: "emailNotification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailNotification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#feature_bundle AnalyticsAnalyticsInstance#feature_bundle}.</summary>
        [JsiiProperty(name: "featureBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#freeform_tags AnalyticsAnalyticsInstance#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#id AnalyticsAnalyticsInstance#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#idcs_access_token AnalyticsAnalyticsInstance#idcs_access_token}.</summary>
        [JsiiProperty(name: "idcsAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdcsAccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#kms_key_id AnalyticsAnalyticsInstance#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_endpoint_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_endpoint_details AnalyticsAnalyticsInstance#network_endpoint_details}
        /// </remarks>
        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails? NetworkEndpointDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#state AnalyticsAnalyticsInstance#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#timeouts AnalyticsAnalyticsInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#update_channel AnalyticsAnalyticsInstance#update_channel}.</summary>
        [JsiiProperty(name: "updateChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateChannel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalyticsAnalyticsInstanceConfig), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>capacity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity AnalyticsAnalyticsInstance#capacity}
            /// </remarks>
            [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacity\"}")]
            public oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity Capacity
            {
                get => GetInstanceProperty<oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#compartment_id AnalyticsAnalyticsInstance#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#feature_set AnalyticsAnalyticsInstance#feature_set}.</summary>
            [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
            public string FeatureSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#license_type AnalyticsAnalyticsInstance#license_type}.</summary>
            [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
            public string LicenseType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#name AnalyticsAnalyticsInstance#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#admin_user AnalyticsAnalyticsInstance#admin_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#defined_tags AnalyticsAnalyticsInstance#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#description AnalyticsAnalyticsInstance#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#domain_id AnalyticsAnalyticsInstance#domain_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#email_notification AnalyticsAnalyticsInstance#email_notification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailNotification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailNotification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#feature_bundle AnalyticsAnalyticsInstance#feature_bundle}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureBundle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#freeform_tags AnalyticsAnalyticsInstance#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#id AnalyticsAnalyticsInstance#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#idcs_access_token AnalyticsAnalyticsInstance#idcs_access_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idcsAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdcsAccessToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#kms_key_id AnalyticsAnalyticsInstance#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_endpoint_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#network_endpoint_details AnalyticsAnalyticsInstance#network_endpoint_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetails\"}", isOptional: true)]
            public oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails? NetworkEndpointDetails
            {
                get => GetInstanceProperty<oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#state AnalyticsAnalyticsInstance#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#timeouts AnalyticsAnalyticsInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceTimeouts\"}", isOptional: true)]
            public oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#update_channel AnalyticsAnalyticsInstance#update_channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateChannel
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
