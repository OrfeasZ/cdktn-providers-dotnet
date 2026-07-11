using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationJobProvisionOnDemand
{
    [JsiiInterface(nativeType: typeof(ISynchronizationJobProvisionOnDemandParameter), fullyQualifiedName: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameter")]
    public interface ISynchronizationJobProvisionOnDemandParameter
    {
        /// <summary>The identifier of the synchronization rule to be applied.</summary>
        /// <remarks>
        /// This rule ID is defined in the schema for a given synchronization job or template.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#rule_id SynchronizationJobProvisionOnDemand#rule_id}
        /// </remarks>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        string RuleId
        {
            get;
        }

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#subject SynchronizationJobProvisionOnDemand#subject}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameterSubject\"},\"kind\":\"array\"}}]}}")]
        object Subject
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynchronizationJobProvisionOnDemandParameter), fullyQualifiedName: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameter")]
        internal sealed class _Proxy : DeputyBase, azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The identifier of the synchronization rule to be applied.</summary>
            /// <remarks>
            /// This rule ID is defined in the schema for a given synchronization job or template.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#rule_id SynchronizationJobProvisionOnDemand#rule_id}
            /// </remarks>
            [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>subject block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#subject SynchronizationJobProvisionOnDemand#subject}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "subject", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameterSubject\"},\"kind\":\"array\"}}]}}")]
            public object Subject
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
