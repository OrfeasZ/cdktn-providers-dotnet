using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceDeploymentConfigurationLinearConfigurationOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationLinearConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsServiceDeploymentConfigurationLinearConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsServiceDeploymentConfigurationLinearConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsServiceDeploymentConfigurationLinearConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceDeploymentConfigurationLinearConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetStepBakeTimeInMinutes")]
        public virtual void ResetStepBakeTimeInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepPercent")]
        public virtual void ResetStepPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepBakeTimeInMinutesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepBakeTimeInMinutesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StepPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "stepBakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepBakeTimeInMinutes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StepPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
