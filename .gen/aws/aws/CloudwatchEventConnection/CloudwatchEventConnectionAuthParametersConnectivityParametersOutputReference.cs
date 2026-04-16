using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersOutputReference), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventConnectionAuthParametersConnectivityParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventConnectionAuthParametersConnectivityParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventConnectionAuthParametersConnectivityParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventConnectionAuthParametersConnectivityParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResourceParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters\"}}]")]
        public virtual void PutResourceParameters(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters)}, new object[]{@value});
        }

        [JsiiProperty(name: "resourceParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParametersOutputReference\"}")]
        public virtual aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParametersOutputReference ResourceParameters
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceParametersInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters? ResourceParametersInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParameters\"}", isOptional: true)]
        public virtual aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParameters? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
