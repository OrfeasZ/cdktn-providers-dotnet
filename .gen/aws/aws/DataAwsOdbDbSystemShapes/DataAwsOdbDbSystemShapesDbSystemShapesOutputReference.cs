using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbDbSystemShapes
{
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbDbSystemShapes.DataAwsOdbDbSystemShapesDbSystemShapesOutputReference), fullyQualifiedName: "aws.dataAwsOdbDbSystemShapes.DataAwsOdbDbSystemShapesDbSystemShapesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsOdbDbSystemShapesDbSystemShapesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsOdbDbSystemShapesDbSystemShapesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsOdbDbSystemShapesDbSystemShapesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbDbSystemShapesDbSystemShapesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availableCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCoreCountPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableDataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableDataStoragePerServerInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDataStoragePerServerInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableDbNodePerNodeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDbNodePerNodeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableDbNodeStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDbNodeStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableMemoryPerNodeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableMemoryPerNodeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "coreCountIncrement", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreCountIncrement
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximumNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCoreCountPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minDataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinDataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minDbNodeStoragePerNodeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinDbNodeStoragePerNodeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minimumCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minimumNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minMemoryPerNodeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinMemoryPerNodeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeMinimumCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuntimeMinimumCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shapeFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsOdbDbSystemShapes.DataAwsOdbDbSystemShapesDbSystemShapes\"}", isOptional: true)]
        public virtual aws.DataAwsOdbDbSystemShapes.IDataAwsOdbDbSystemShapesDbSystemShapes? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsOdbDbSystemShapes.IDataAwsOdbDbSystemShapesDbSystemShapes?>();
            set => SetInstanceProperty(value);
        }
    }
}
