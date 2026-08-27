using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorOriginGroup
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorOriginGroupConfig), fullyQualifiedName: "azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupConfig")]
    public interface ICdnFrontdoorOriginGroupConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#cdn_frontdoor_profile_id CdnFrontdoorOriginGroup#cdn_frontdoor_profile_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorProfileId", typeJson: "{\"primitive\":\"string\"}")]
        string CdnFrontdoorProfileId
        {
            get;
        }

        /// <summary>load_balancing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#load_balancing CdnFrontdoorOriginGroup#load_balancing}
        /// </remarks>
        [JsiiProperty(name: "loadBalancing", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing\"}")]
        azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing LoadBalancing
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#name CdnFrontdoorOriginGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>health_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#health_probe CdnFrontdoorOriginGroup#health_probe}
        /// </remarks>
        [JsiiProperty(name: "healthProbe", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe? HealthProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#id CdnFrontdoorOriginGroup#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#restore_traffic_time_to_healed_or_new_endpoint_in_minutes CdnFrontdoorOriginGroup#restore_traffic_time_to_healed_or_new_endpoint_in_minutes}.</summary>
        [JsiiProperty(name: "restoreTrafficTimeToHealedOrNewEndpointInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#session_affinity_enabled CdnFrontdoorOriginGroup#session_affinity_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sessionAffinityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SessionAffinityEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#timeouts CdnFrontdoorOriginGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorOriginGroupConfig), fullyQualifiedName: "azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#cdn_frontdoor_profile_id CdnFrontdoorOriginGroup#cdn_frontdoor_profile_id}.</summary>
            [JsiiProperty(name: "cdnFrontdoorProfileId", typeJson: "{\"primitive\":\"string\"}")]
            public string CdnFrontdoorProfileId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>load_balancing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#load_balancing CdnFrontdoorOriginGroup#load_balancing}
            /// </remarks>
            [JsiiProperty(name: "loadBalancing", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing\"}")]
            public azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing LoadBalancing
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#name CdnFrontdoorOriginGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>health_probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#health_probe CdnFrontdoorOriginGroup#health_probe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthProbe", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupHealthProbe\"}", isOptional: true)]
            public azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe? HealthProbe
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupHealthProbe?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#id CdnFrontdoorOriginGroup#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#restore_traffic_time_to_healed_or_new_endpoint_in_minutes CdnFrontdoorOriginGroup#restore_traffic_time_to_healed_or_new_endpoint_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreTrafficTimeToHealedOrNewEndpointInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#session_affinity_enabled CdnFrontdoorOriginGroup#session_affinity_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionAffinityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SessionAffinityEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/cdn_frontdoor_origin_group#timeouts CdnFrontdoorOriginGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupTimeouts\"}", isOptional: true)]
            public azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupTimeouts?>();
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
