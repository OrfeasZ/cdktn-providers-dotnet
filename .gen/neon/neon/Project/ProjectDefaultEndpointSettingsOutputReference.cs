using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiClass(nativeType: typeof(neon.Project.ProjectDefaultEndpointSettingsOutputReference), fullyQualifiedName: "neon.project.ProjectDefaultEndpointSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ProjectDefaultEndpointSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ProjectDefaultEndpointSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ProjectDefaultEndpointSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProjectDefaultEndpointSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAutoscalingLimitMaxCu")]
        public virtual void ResetAutoscalingLimitMaxCu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingLimitMinCu")]
        public virtual void ResetAutoscalingLimitMinCu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuspendTimeoutSeconds")]
        public virtual void ResetSuspendTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMaxCuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutoscalingLimitMaxCuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMinCuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutoscalingLimitMinCuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "suspendTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SuspendTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoscalingLimitMaxCu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutoscalingLimitMinCu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "suspendTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuspendTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"neon.project.ProjectDefaultEndpointSettings\"}", isOptional: true)]
        public virtual neon.Project.IProjectDefaultEndpointSettings? InternalValue
        {
            get => GetInstanceProperty<neon.Project.IProjectDefaultEndpointSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
