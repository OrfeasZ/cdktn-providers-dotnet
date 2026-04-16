using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WaitingRoomEvent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.waitingRoomEvent.WaitingRoomEventConfig")]
    public class WaitingRoomEventConfig : cloudflare.WaitingRoomEvent.IWaitingRoomEventConfig
    {
        /// <summary>An ISO 8601 timestamp that marks the end of the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#event_end_time WaitingRoomEvent#event_end_time}
        /// </remarks>
        [JsiiProperty(name: "eventEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public string EventEndTime
        {
            get;
            set;
        }

        /// <summary>An ISO 8601 timestamp that marks the start of the event.</summary>
        /// <remarks>
        /// At this time, queued users will be processed with the event's configuration. The start time must be at least one minute before <c>event_end_time</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#event_start_time WaitingRoomEvent#event_start_time}
        /// </remarks>
        [JsiiProperty(name: "eventStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string EventStartTime
        {
            get;
            set;
        }

        /// <summary>A unique name to identify the event. Only alphanumeric characters, hyphens and underscores are allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#name WaitingRoomEvent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#waiting_room_id WaitingRoomEvent#waiting_room_id}.</summary>
        [JsiiProperty(name: "waitingRoomId", typeJson: "{\"primitive\":\"string\"}")]
        public string WaitingRoomId
        {
            get;
            set;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#zone_id WaitingRoomEvent#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string ZoneId
        {
            get;
            set;
        }

        /// <summary>If set, the event will override the waiting room's `custom_page_html` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#custom_page_html WaitingRoomEvent#custom_page_html}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomPageHtml
        {
            get;
            set;
        }

        /// <summary>A note that you can use to add more details about the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#description WaitingRoomEvent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _disableSessionRenewal;

        /// <summary>If set, the event will override the waiting room's `disable_session_renewal` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#disable_session_renewal WaitingRoomEvent#disable_session_renewal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableSessionRenewal
        {
            get => _disableSessionRenewal;
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
                _disableSessionRenewal = value;
            }
        }

        /// <summary>If set, the event will override the waiting room's `new_users_per_minute` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it. This can only be set if the event's <c>total_active_users</c> property is also set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#new_users_per_minute WaitingRoomEvent#new_users_per_minute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NewUsersPerMinute
        {
            get;
            set;
        }

        /// <summary>An ISO 8601 timestamp that marks when to begin queueing all users before the event starts.</summary>
        /// <remarks>
        /// The prequeue must start at least five minutes before <c>event_start_time</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#prequeue_start_time WaitingRoomEvent#prequeue_start_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prequeueStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrequeueStartTime
        {
            get;
            set;
        }

        /// <summary>If set, the event will override the waiting room's `queueing_method` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#queueing_method WaitingRoomEvent#queueing_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueueingMethod
        {
            get;
            set;
        }

        /// <summary>If set, the event will override the waiting room's `session_duration` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#session_duration WaitingRoomEvent#session_duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionDuration
        {
            get;
            set;
        }

        private object? _shuffleAtEventStart;

        /// <summary>If enabled, users in the prequeue will be shuffled randomly at the `event_start_time`.</summary>
        /// <remarks>
        /// Requires that <c>prequeue_start_time</c> is not null. This is useful for situations when many users will join the event prequeue at the same time and you want to shuffle them to ensure fairness. Naturally, it makes the most sense to enable this feature when the <c>queueing_method</c> during the event respects ordering such as <strong>fifo</strong>, or else the shuffling may be unnecessary.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#shuffle_at_event_start WaitingRoomEvent#shuffle_at_event_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shuffleAtEventStart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShuffleAtEventStart
        {
            get => _shuffleAtEventStart;
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
                _shuffleAtEventStart = value;
            }
        }

        private object? _suspended;

        /// <summary>Suspends or allows an event.</summary>
        /// <remarks>
        /// If set to <c>true</c>, the event is ignored and traffic will be handled based on the waiting room configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#suspended WaitingRoomEvent#suspended}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suspended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Suspended
        {
            get => _suspended;
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
                _suspended = value;
            }
        }

        /// <summary>If set, the event will override the waiting room's `total_active_users` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it. This can only be set if the event's <c>new_users_per_minute</c> property is also set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#total_active_users WaitingRoomEvent#total_active_users}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalActiveUsers
        {
            get;
            set;
        }

        /// <summary>If set, the event will override the waiting room's `turnstile_action` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        /// Available values: "log", "infinite_queue".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#turnstile_action WaitingRoomEvent#turnstile_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TurnstileAction
        {
            get;
            set;
        }

        /// <summary>If set, the event will override the waiting room's `turnstile_mode` property while it is active.</summary>
        /// <remarks>
        /// If null, the event will inherit it.
        /// Available values: "off", "invisible", "visible_non_interactive", "visible_managed".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room_event#turnstile_mode WaitingRoomEvent#turnstile_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TurnstileMode
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
