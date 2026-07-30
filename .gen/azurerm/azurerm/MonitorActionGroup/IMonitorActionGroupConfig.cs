using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    [JsiiInterface(nativeType: typeof(IMonitorActionGroupConfig), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupConfig")]
    public interface IMonitorActionGroupConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#resource_group_name MonitorActionGroup#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#short_name MonitorActionGroup#short_name}.</summary>
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
        string ShortName
        {
            get;
        }

        /// <summary>arm_role_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#arm_role_receiver MonitorActionGroup#arm_role_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupArmRoleReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "armRoleReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArmRoleReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>automation_runbook_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#automation_runbook_receiver MonitorActionGroup#automation_runbook_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupAutomationRunbookReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "automationRunbookReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAutomationRunbookReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutomationRunbookReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_app_push_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#azure_app_push_receiver MonitorActionGroup#azure_app_push_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupAzureAppPushReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azureAppPushReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureAppPushReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureAppPushReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_function_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#azure_function_receiver MonitorActionGroup#azure_function_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupAzureFunctionReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azureFunctionReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureFunctionReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureFunctionReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>email_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#email_receiver MonitorActionGroup#email_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupEmailReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "emailReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEmailReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EmailReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#enabled MonitorActionGroup#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        /// <summary>event_hub_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#event_hub_receiver MonitorActionGroup#event_hub_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupEventHubReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "eventHubReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEventHubReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EventHubReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#id MonitorActionGroup#id}.</summary>
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

        /// <summary>itsm_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#itsm_receiver MonitorActionGroup#itsm_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupItsmReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "itsmReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupItsmReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ItsmReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#location MonitorActionGroup#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>logic_app_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#logic_app_receiver MonitorActionGroup#logic_app_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupLogicAppReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "logicAppReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupLogicAppReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogicAppReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>sms_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#sms_receiver MonitorActionGroup#sms_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupSmsReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "smsReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupSmsReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SmsReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#tags MonitorActionGroup#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#timeouts MonitorActionGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorActionGroup.IMonitorActionGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>voice_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#voice_receiver MonitorActionGroup#voice_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "voiceReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VoiceReceiver
        {
            get
            {
                return null;
            }
        }

        /// <summary>webhook_receiver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#webhook_receiver MonitorActionGroup#webhook_receiver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiver" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "webhookReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebhookReceiver
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorActionGroupConfig), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorActionGroup.IMonitorActionGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#resource_group_name MonitorActionGroup#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#short_name MonitorActionGroup#short_name}.</summary>
            [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
            public string ShortName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>arm_role_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#arm_role_receiver MonitorActionGroup#arm_role_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupArmRoleReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "armRoleReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupArmRoleReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ArmRoleReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>automation_runbook_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#automation_runbook_receiver MonitorActionGroup#automation_runbook_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupAutomationRunbookReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automationRunbookReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAutomationRunbookReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AutomationRunbookReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>azure_app_push_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#azure_app_push_receiver MonitorActionGroup#azure_app_push_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupAzureAppPushReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureAppPushReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureAppPushReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AzureAppPushReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>azure_function_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#azure_function_receiver MonitorActionGroup#azure_function_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupAzureFunctionReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureFunctionReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupAzureFunctionReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AzureFunctionReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>email_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#email_receiver MonitorActionGroup#email_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupEmailReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEmailReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EmailReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#enabled MonitorActionGroup#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>event_hub_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#event_hub_receiver MonitorActionGroup#event_hub_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupEventHubReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventHubReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupEventHubReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EventHubReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#id MonitorActionGroup#id}.</summary>
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

            /// <summary>itsm_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#itsm_receiver MonitorActionGroup#itsm_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupItsmReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "itsmReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupItsmReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ItsmReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#location MonitorActionGroup#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logic_app_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#logic_app_receiver MonitorActionGroup#logic_app_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupLogicAppReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logicAppReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupLogicAppReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogicAppReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sms_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#sms_receiver MonitorActionGroup#sms_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupSmsReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smsReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupSmsReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SmsReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#tags MonitorActionGroup#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#timeouts MonitorActionGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupTimeouts\"}", isOptional: true)]
            public azurerm.MonitorActionGroup.IMonitorActionGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MonitorActionGroup.IMonitorActionGroupTimeouts?>();
            }

            /// <summary>voice_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#voice_receiver MonitorActionGroup#voice_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "voiceReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VoiceReceiver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>webhook_receiver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/monitor_action_group#webhook_receiver MonitorActionGroup#webhook_receiver}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiver" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhookReceiver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiver\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WebhookReceiver
            {
                get => GetInstanceProperty<object?>();
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
