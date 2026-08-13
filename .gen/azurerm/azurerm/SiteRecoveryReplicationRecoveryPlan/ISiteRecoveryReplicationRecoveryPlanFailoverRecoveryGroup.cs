using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicationRecoveryPlan
{
    [JsiiInterface(nativeType: typeof(ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup), fullyQualifiedName: "azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup")]
    public interface ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup
    {
        /// <summary>post_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/site_recovery_replication_recovery_plan#post_action SiteRecoveryReplicationRecoveryPlan#post_action}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "postAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>pre_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/site_recovery_replication_recovery_plan#pre_action SiteRecoveryReplicationRecoveryPlan#pre_action}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "preAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup), fullyQualifiedName: "azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>post_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/site_recovery_replication_recovery_plan#post_action SiteRecoveryReplicationRecoveryPlan#post_action}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPostAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>pre_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/site_recovery_replication_recovery_plan#pre_action SiteRecoveryReplicationRecoveryPlan#pre_action}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroupPreAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PreAction
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
