using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    [JsiiInterface(nativeType: typeof(ILambdamicrovmsMicrovmIdlePolicy), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy")]
    public interface ILambdamicrovmsMicrovmIdlePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#auto_resume_enabled LambdamicrovmsMicrovm#auto_resume_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoResumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutoResumeEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#max_idle_duration_seconds LambdamicrovmsMicrovm#max_idle_duration_seconds}.</summary>
        [JsiiProperty(name: "maxIdleDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double MaxIdleDurationSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#suspended_duration_seconds LambdamicrovmsMicrovm#suspended_duration_seconds}.</summary>
        [JsiiProperty(name: "suspendedDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double SuspendedDurationSeconds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdamicrovmsMicrovmIdlePolicy), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmIdlePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmIdlePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#auto_resume_enabled LambdamicrovmsMicrovm#auto_resume_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "autoResumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutoResumeEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#max_idle_duration_seconds LambdamicrovmsMicrovm#max_idle_duration_seconds}.</summary>
            [JsiiProperty(name: "maxIdleDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxIdleDurationSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#suspended_duration_seconds LambdamicrovmsMicrovm#suspended_duration_seconds}.</summary>
            [JsiiProperty(name: "suspendedDurationSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double SuspendedDurationSeconds
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
