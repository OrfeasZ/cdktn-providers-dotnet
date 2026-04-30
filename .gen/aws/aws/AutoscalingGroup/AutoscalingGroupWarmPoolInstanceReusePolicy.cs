using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicy")]
    public class AutoscalingGroupWarmPoolInstanceReusePolicy : aws.AutoscalingGroup.IAutoscalingGroupWarmPoolInstanceReusePolicy
    {
        private object? _reuseOnScaleIn;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/autoscaling_group#reuse_on_scale_in AutoscalingGroup#reuse_on_scale_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reuseOnScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReuseOnScaleIn
        {
            get => _reuseOnScaleIn;
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
                _reuseOnScaleIn = value;
            }
        }
    }
}
