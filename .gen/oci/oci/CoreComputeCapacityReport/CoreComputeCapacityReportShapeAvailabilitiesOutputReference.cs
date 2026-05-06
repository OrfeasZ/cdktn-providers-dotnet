using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReport
{
    [JsiiClass(nativeType: typeof(oci.CoreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesOutputReference), fullyQualifiedName: "oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CoreComputeCapacityReportShapeAvailabilitiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CoreComputeCapacityReportShapeAvailabilitiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CoreComputeCapacityReportShapeAvailabilitiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreComputeCapacityReportShapeAvailabilitiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig\"}}]")]
        public virtual void PutInstanceShapeConfig(oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFaultDomain")]
        public virtual void ResetFaultDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceShapeConfig")]
        public virtual void ResetInstanceShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "availabilityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailableCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceShapeConfig", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfigOutputReference\"}")]
        public virtual oci.CoreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfigOutputReference InstanceShapeConfig
        {
            get => GetInstanceProperty<oci.CoreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "faultDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FaultDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceShapeConfigInput", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig\"}", isOptional: true)]
        public virtual oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig? InstanceShapeConfigInput
        {
            get => GetInstanceProperty<oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilitiesInstanceShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreComputeCapacityReport.CoreComputeCapacityReportShapeAvailabilities\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilities cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CoreComputeCapacityReport.ICoreComputeCapacityReportShapeAvailabilities).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
