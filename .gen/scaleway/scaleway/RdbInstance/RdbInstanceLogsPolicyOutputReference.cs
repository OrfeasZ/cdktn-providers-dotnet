using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiClass(nativeType: typeof(scaleway.RdbInstance.RdbInstanceLogsPolicyOutputReference), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceLogsPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RdbInstanceLogsPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RdbInstanceLogsPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RdbInstanceLogsPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RdbInstanceLogsPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxAgeRetention")]
        public virtual void ResetMaxAgeRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalDiskRetention")]
        public virtual void ResetTotalDiskRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAgeRetentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxAgeRetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalDiskRetentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalDiskRetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxAgeRetention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAgeRetention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalDiskRetention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalDiskRetention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLogsPolicy\"}", isOptional: true)]
        public virtual scaleway.RdbInstance.IRdbInstanceLogsPolicy? InternalValue
        {
            get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstanceLogsPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
