using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLambdamicrovmsImageVersion
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionHooksMicrovmHooksOutputReference), fullyQualifiedName: "aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionHooksMicrovmHooksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLambdamicrovmsImageVersionHooksMicrovmHooksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLambdamicrovmsImageVersionHooksMicrovmHooksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsLambdamicrovmsImageVersionHooksMicrovmHooksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdamicrovmsImageVersionHooksMicrovmHooksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "resume", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resume
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resumeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResumeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "run", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Run
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RunTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "suspend", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Suspend
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suspendTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuspendTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "terminate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Terminate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "terminateTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TerminateTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionHooksMicrovmHooks\"}", isOptional: true)]
        public virtual aws.DataAwsLambdamicrovmsImageVersion.IDataAwsLambdamicrovmsImageVersionHooksMicrovmHooks? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsLambdamicrovmsImageVersion.IDataAwsLambdamicrovmsImageVersionHooksMicrovmHooks?>();
            set => SetInstanceProperty(value);
        }
    }
}
