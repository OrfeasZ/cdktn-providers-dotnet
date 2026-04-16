using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.loadBalancerPool.LoadBalancerPoolConfig")]
    public class LoadBalancerPoolConfig : cloudflare.LoadBalancerPool.ILoadBalancerPoolConfig
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#account_id LoadBalancerPool#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>A short name (tag) for the pool. Only alphanumeric characters, hyphens, and underscores are allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#name LoadBalancerPool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _origins;

        /// <summary>The list of origins within this pool.</summary>
        /// <remarks>
        /// Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origins LoadBalancerPool#origins}
        /// </remarks>
        [JsiiProperty(name: "origins", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOrigins\"},\"kind\":\"array\"}}]}}")]
        public object Origins
        {
            get => _origins;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _origins = value;
            }
        }

        /// <summary>A list of regions from which to run health checks. Null means every Cloudflare data center.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#check_regions LoadBalancerPool#check_regions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CheckRegions
        {
            get;
            set;
        }

        /// <summary>A human-readable description of the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#description LoadBalancerPool#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _enabled;

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
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
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
            get;
            set;
        }

        /// <summary>Configures load shedding policies and percentages for the pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#load_shedding LoadBalancerPool#load_shedding}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadShedding", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding\"}", isOptional: true)]
        public cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding? LoadShedding
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>The ID of the Monitor to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#monitor LoadBalancerPool#monitor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Monitor
        {
            get;
            set;
        }

        /// <summary>The ID of the Monitor Group to use for checking the health of origins within this pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#monitor_group LoadBalancerPool#monitor_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonitorGroup
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Filter pool and origin health notifications by resource type or health status. Use null to reset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#notification_filter LoadBalancerPool#notification_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationFilter", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolNotificationFilter\"}", isOptional: true)]
        public cloudflare.LoadBalancerPool.ILoadBalancerPoolNotificationFilter? NotificationFilter
        {
            get;
            set;
        }

        /// <summary>Configures origin steering for the pool. Controls how origins are selected for new sessions and traffic without session affinity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#origin_steering LoadBalancerPool#origin_steering}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originSteering", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginSteering\"}", isOptional: true)]
        public cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginSteering? OriginSteering
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
