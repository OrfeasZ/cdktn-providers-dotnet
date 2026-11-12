using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatements")]
    public class CoreInstancePoolOverridePolicyOverrideStatements : oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements
    {
        private object _overrideOptions;

        /// <summary>override_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override_options CoreInstancePool#override_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "overrideOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions\"},\"kind\":\"array\"}}]}}")]
        public object OverrideOptions
        {
            get => _overrideOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overrideOptions = value;
            }
        }

        /// <summary>selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#selector CoreInstancePool#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsSelector\"}")]
        public oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsSelector Selector
        {
            get;
            set;
        }
    }
}
