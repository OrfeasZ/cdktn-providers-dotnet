using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyApp
{
    [JsiiClass(nativeType: typeof(aws.AmplifyApp.AmplifyAppJobConfigOutputReference), fullyQualifiedName: "aws.amplifyApp.AmplifyAppJobConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AmplifyAppJobConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AmplifyAppJobConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AmplifyAppJobConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AmplifyAppJobConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBuildComputeType")]
        public virtual void ResetBuildComputeType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildComputeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildComputeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "buildComputeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildComputeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.amplifyApp.AmplifyAppJobConfig\"}", isOptional: true)]
        public virtual aws.AmplifyApp.IAmplifyAppJobConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AmplifyApp.IAmplifyAppJobConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
