using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationJobProvisionOnDemand
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameter")]
    public class SynchronizationJobProvisionOnDemandParameter : azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameter
    {
        /// <summary>The identifier of the synchronization rule to be applied.</summary>
        /// <remarks>
        /// This rule ID is defined in the schema for a given synchronization job or template.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#rule_id SynchronizationJobProvisionOnDemand#rule_id}
        /// </remarks>
        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleId
        {
            get;
            set;
        }

        private object _subject;

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#subject SynchronizationJobProvisionOnDemand#subject}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameterSubject\"},\"kind\":\"array\"}}]}}")]
        public object Subject
        {
            get => _subject;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameterSubject).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subject = value;
            }
        }
    }
}
