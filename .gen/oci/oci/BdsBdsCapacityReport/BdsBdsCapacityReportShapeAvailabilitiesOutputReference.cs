using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsCapacityReport
{
    [JsiiClass(nativeType: typeof(oci.BdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesOutputReference), fullyQualifiedName: "oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BdsBdsCapacityReportShapeAvailabilitiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BdsBdsCapacityReportShapeAvailabilitiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BdsBdsCapacityReportShapeAvailabilitiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsCapacityReportShapeAvailabilitiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetShapeConfig")]
        public virtual void ResetShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "domainLevelCapacityReports", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesDomainLevelCapacityReportsList\"}")]
        public virtual oci.BdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesDomainLevelCapacityReportsList DomainLevelCapacityReports
        {
            get => GetInstanceProperty<oci.BdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesDomainLevelCapacityReportsList>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfigOutputReference\"}")]
        public virtual oci.BdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.BdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilitiesShapeConfig\"}", isOptional: true)]
        public virtual oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilitiesShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.bdsBdsCapacityReport.BdsBdsCapacityReportShapeAvailabilities\"}]}}", isOptional: true)]
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
                        case oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilities cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsBdsCapacityReport.IBdsBdsCapacityReportShapeAvailabilities).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
