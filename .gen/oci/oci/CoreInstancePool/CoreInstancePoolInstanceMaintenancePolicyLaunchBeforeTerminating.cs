using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating")]
    public class CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating : oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating
    {
        private object _isFullRefresh;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#is_full_refresh CoreInstancePool#is_full_refresh}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isFullRefresh", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsFullRefresh
        {
            get => _isFullRefresh;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isFullRefresh = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/core_instance_pool#max_healthy_percent CoreInstancePool#max_healthy_percent}.</summary>
        [JsiiProperty(name: "maxHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxHealthyPercent
        {
            get;
            set;
        }
    }
}
