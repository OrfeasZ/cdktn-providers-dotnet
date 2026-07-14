using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGateway
{
    [JsiiInterface(nativeType: typeof(ISpringCloudGatewayConfig), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayConfig")]
    public interface ISpringCloudGatewayConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#name SpringCloudGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#spring_cloud_service_id SpringCloudGateway#spring_cloud_service_id}.</summary>
        [JsiiProperty(name: "springCloudServiceId", typeJson: "{\"primitive\":\"string\"}")]
        string SpringCloudServiceId
        {
            get;
        }

        /// <summary>api_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#api_metadata SpringCloudGateway#api_metadata}
        /// </remarks>
        [JsiiProperty(name: "apiMetadata", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayApiMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata? ApiMetadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#application_performance_monitoring_ids SpringCloudGateway#application_performance_monitoring_ids}.</summary>
        [JsiiProperty(name: "applicationPerformanceMonitoringIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApplicationPerformanceMonitoringIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#application_performance_monitoring_types SpringCloudGateway#application_performance_monitoring_types}.</summary>
        [JsiiProperty(name: "applicationPerformanceMonitoringTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApplicationPerformanceMonitoringTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>client_authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#client_authorization SpringCloudGateway#client_authorization}
        /// </remarks>
        [JsiiProperty(name: "clientAuthorization", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayClientAuthorization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization? ClientAuthorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#cors SpringCloudGateway#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayCors? Cors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#environment_variables SpringCloudGateway#environment_variables}.</summary>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#https_only SpringCloudGateway#https_only}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#id SpringCloudGateway#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#instance_count SpringCloudGateway#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>local_response_cache_per_instance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#local_response_cache_per_instance SpringCloudGateway#local_response_cache_per_instance}
        /// </remarks>
        [JsiiProperty(name: "localResponseCachePerInstance", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerInstance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance? LocalResponseCachePerInstance
        {
            get
            {
                return null;
            }
        }

        /// <summary>local_response_cache_per_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#local_response_cache_per_route SpringCloudGateway#local_response_cache_per_route}
        /// </remarks>
        [JsiiProperty(name: "localResponseCachePerRoute", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute? LocalResponseCachePerRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#public_network_access_enabled SpringCloudGateway#public_network_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>quota block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#quota SpringCloudGateway#quota}
        /// </remarks>
        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayQuota\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayQuota? Quota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#sensitive_environment_variables SpringCloudGateway#sensitive_environment_variables}.</summary>
        [JsiiProperty(name: "sensitiveEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SensitiveEnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>sso block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#sso SpringCloudGateway#sso}
        /// </remarks>
        [JsiiProperty(name: "sso", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewaySso\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewaySso? Sso
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#timeouts SpringCloudGateway#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudGateway.ISpringCloudGatewayTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudGatewayConfig), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGatewayConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudGateway.ISpringCloudGatewayConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#name SpringCloudGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#spring_cloud_service_id SpringCloudGateway#spring_cloud_service_id}.</summary>
            [JsiiProperty(name: "springCloudServiceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SpringCloudServiceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>api_metadata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#api_metadata SpringCloudGateway#api_metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiMetadata", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayApiMetadata\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata? ApiMetadata
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#application_performance_monitoring_ids SpringCloudGateway#application_performance_monitoring_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationPerformanceMonitoringIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApplicationPerformanceMonitoringIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#application_performance_monitoring_types SpringCloudGateway#application_performance_monitoring_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationPerformanceMonitoringTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApplicationPerformanceMonitoringTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>client_authorization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#client_authorization SpringCloudGateway#client_authorization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientAuthorization", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayClientAuthorization\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization? ClientAuthorization
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization?>();
            }

            /// <summary>cors block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#cors SpringCloudGateway#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayCors\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayCors? Cors
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayCors?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#environment_variables SpringCloudGateway#environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#https_only SpringCloudGateway#https_only}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#id SpringCloudGateway#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#instance_count SpringCloudGateway#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>local_response_cache_per_instance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#local_response_cache_per_instance SpringCloudGateway#local_response_cache_per_instance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localResponseCachePerInstance", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerInstance\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance? LocalResponseCachePerInstance
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance?>();
            }

            /// <summary>local_response_cache_per_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#local_response_cache_per_route SpringCloudGateway#local_response_cache_per_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localResponseCachePerRoute", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute? LocalResponseCachePerRoute
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#public_network_access_enabled SpringCloudGateway#public_network_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>quota block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#quota SpringCloudGateway#quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayQuota\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayQuota? Quota
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayQuota?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#sensitive_environment_variables SpringCloudGateway#sensitive_environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SensitiveEnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>sso block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#sso SpringCloudGateway#sso}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sso", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewaySso\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewaySso? Sso
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewaySso?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/spring_cloud_gateway#timeouts SpringCloudGateway#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayTimeouts\"}", isOptional: true)]
            public azurerm.SpringCloudGateway.ISpringCloudGatewayTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayTimeouts?>();
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
