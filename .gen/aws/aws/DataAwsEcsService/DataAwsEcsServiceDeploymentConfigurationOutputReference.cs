using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcsService
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationOutputReference), fullyQualifiedName: "aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEcsServiceDeploymentConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEcsServiceDeploymentConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsServiceDeploymentConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsServiceDeploymentConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alarms", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationAlarmsList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationAlarmsList Alarms
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationAlarmsList>()!;
        }

        [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BakeTimeInMinutes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "canaryConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationCanaryConfigurationList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationCanaryConfigurationList CanaryConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationCanaryConfigurationList>()!;
        }

        [JsiiProperty(name: "deploymentCircuitBreaker", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerList DeploymentCircuitBreaker
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationDeploymentCircuitBreakerList>()!;
        }

        [JsiiProperty(name: "lifecycleHook", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationLifecycleHookList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationLifecycleHookList LifecycleHook
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationLifecycleHookList>()!;
        }

        [JsiiProperty(name: "linearConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationLinearConfigurationList\"}")]
        public virtual aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationLinearConfigurationList LinearConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.DataAwsEcsServiceDeploymentConfigurationLinearConfigurationList>()!;
        }

        [JsiiProperty(name: "maximumPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumPercent
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumHealthyPercent
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEcsService.DataAwsEcsServiceDeploymentConfiguration\"}", isOptional: true)]
        public virtual aws.DataAwsEcsService.IDataAwsEcsServiceDeploymentConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEcsService.IDataAwsEcsServiceDeploymentConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
