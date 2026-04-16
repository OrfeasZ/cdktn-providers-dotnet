using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolConfig), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolConfig")]
    public interface ILoadBalancerPoolConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#account_id LoadBalancerPool#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#name LoadBalancerPool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The list of origins within this pool.</summary>
        /// <remarks>
        /// Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origins LoadBalancerPool#origins}
        /// </remarks>
        [JsiiProperty(name: "origins", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOrigins\"},\"kind\":\"array\"}}]}}")]
        object Origins
        {
            get;
        }

        /// <summary>A list of regions from which to run health checks. Null means every Cloudflare data center.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#check_regions LoadBalancerPool#check_regions}
        /// </remarks>
        [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CheckRegions
        {
            get
            {
                return null;
            }
        }

        /// <summary>A human-readable description of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#description LoadBalancerPool#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable (the default) or disable this pool.</summary>
        /// <remarks>
        /// Disabled pools will not receive traffic and are excluded from health checks. Disabling a pool will cause any load balancers using it to failover to the next pool (if any).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#enabled LoadBalancerPool#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The latitude of the data center containing the origins used in this pool in decimal degrees.</summary>
        /// <remarks>
        /// If this is set, longitude must also be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#latitude LoadBalancerPool#latitude}
        /// </remarks>
        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Latitude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures load shedding policies and percentages for the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#load_shedding LoadBalancerPool#load_shedding}
        /// </remarks>
        [JsiiProperty(name: "loadShedding", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding? LoadShedding
        {
            get
            {
                return null;
            }
        }

        /// <summary>The longitude of the data center containing the origins used in this pool in decimal degrees.</summary>
        /// <remarks>
        /// If this is set, latitude must also be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#longitude LoadBalancerPool#longitude}
        /// </remarks>
        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Longitude
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum number of origins that must be healthy for this pool to serve traffic.</summary>
        /// <remarks>
        /// If the number of healthy origins falls below this number, the pool will be marked unhealthy and will failover to the next available pool.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#minimum_origins LoadBalancerPool#minimum_origins}
        /// </remarks>
        [JsiiProperty(name: "minimumOrigins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#monitor LoadBalancerPool#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Monitor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the Monitor Group to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#monitor_group LoadBalancerPool#monitor_group}
        /// </remarks>
        [JsiiProperty(name: "monitorGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonitorGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>This field is now deprecated.</summary>
        /// <remarks>
        /// It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#notification_email LoadBalancerPool#notification_email}
        /// </remarks>
        [JsiiProperty(name: "notificationEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter pool and origin health notifications by resource type or health status. Use null to reset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#notification_filter LoadBalancerPool#notification_filter}
        /// </remarks>
        [JsiiProperty(name: "notificationFilter", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter? NotificationFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origin_steering LoadBalancerPool#origin_steering}
        /// </remarks>
        [JsiiProperty(name: "originSteering", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering? OriginSteering
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolConfig), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#account_id LoadBalancerPool#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#name LoadBalancerPool#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The list of origins within this pool.</summary>
            /// <remarks>
            /// Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origins LoadBalancerPool#origins}
            /// </remarks>
            [JsiiProperty(name: "origins", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOrigins\"},\"kind\":\"array\"}}]}}")]
            public object Origins
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A list of regions from which to run health checks. Null means every Cloudflare data center.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#check_regions LoadBalancerPool#check_regions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CheckRegions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A human-readable description of the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#description LoadBalancerPool#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to enable (the default) or disable this pool.</summary>
            /// <remarks>
            /// Disabled pools will not receive traffic and are excluded from health checks. Disabling a pool will cause any load balancers using it to failover to the next pool (if any).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#enabled LoadBalancerPool#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The latitude of the data center containing the origins used in this pool in decimal degrees.</summary>
            /// <remarks>
            /// If this is set, longitude must also be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#latitude LoadBalancerPool#latitude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Latitude
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures load shedding policies and percentages for the pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#load_shedding LoadBalancerPool#load_shedding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadShedding", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding\"}", isOptional: true)]
            public cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding? LoadShedding
            {
                get => GetInstanceProperty<cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding?>();
            }

            /// <summary>The longitude of the data center containing the origins used in this pool in decimal degrees.</summary>
            /// <remarks>
            /// If this is set, latitude must also be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#longitude LoadBalancerPool#longitude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Longitude
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum number of origins that must be healthy for this pool to serve traffic.</summary>
            /// <remarks>
            /// If the number of healthy origins falls below this number, the pool will be marked unhealthy and will failover to the next available pool.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#minimum_origins LoadBalancerPool#minimum_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumOrigins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumOrigins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#monitor LoadBalancerPool#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Monitor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the Monitor Group to use for checking the health of origins within this pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#monitor_group LoadBalancerPool#monitor_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitorGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonitorGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This field is now deprecated.</summary>
            /// <remarks>
            /// It has been moved to Cloudflare's Centralized Notification service https://developers.cloudflare.com/fundamentals/notifications/. The email address to send health status notifications to. This can be an individual mailbox or a mailing list. Multiple emails can be supplied as a comma delimited list.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#notification_email LoadBalancerPool#notification_email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter pool and origin health notifications by resource type or health status. Use null to reset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#notification_filter LoadBalancerPool#notification_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationFilter", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter\"}", isOptional: true)]
            public cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter? NotificationFilter
            {
                get => GetInstanceProperty<cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter?>();
            }

            /// <summary>Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origin_steering LoadBalancerPool#origin_steering}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originSteering", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering\"}", isOptional: true)]
            public cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering? OriginSteering
            {
                get => GetInstanceProperty<cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering?>();
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
