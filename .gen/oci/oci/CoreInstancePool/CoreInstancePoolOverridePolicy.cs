using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolOverridePolicy")]
    public class CoreInstancePoolOverridePolicy : oci.CoreInstancePool.ICoreInstancePoolOverridePolicy
    {
        private object _overrideStatements;

        /// <summary>override_statements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override_statements CoreInstancePool#override_statements}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "overrideStatements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatements\"},\"kind\":\"array\"}}]}}")]
        public object OverrideStatements
        {
            get => _overrideStatements;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overrideStatements = value;
            }
        }
    }
}
