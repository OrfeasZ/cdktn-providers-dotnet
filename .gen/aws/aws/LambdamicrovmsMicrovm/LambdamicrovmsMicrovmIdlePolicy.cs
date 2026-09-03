using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy")]
    public class LambdamicrovmsMicrovmIdlePolicy : aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy
    {
        private object _autoResumeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#auto_resume_enabled LambdamicrovmsMicrovm#auto_resume_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoResumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object AutoResumeEnabled
        {
            get => _autoResumeEnabled;
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
                _autoResumeEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#max_idle_duration_seconds LambdamicrovmsMicrovm#max_idle_duration_seconds}.</summary>
        [JsiiProperty(name: "maxIdleDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxIdleDurationSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#suspended_duration_seconds LambdamicrovmsMicrovm#suspended_duration_seconds}.</summary>
        [JsiiProperty(name: "suspendedDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double SuspendedDurationSeconds
        {
            get;
            set;
        }
    }
}
