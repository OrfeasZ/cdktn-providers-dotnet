using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesClusterDetailsOutputReference), fullyQualifiedName: "oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesClusterDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsBdsInstancesBdsInstancesClusterDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsBdsInstancesBdsInstancesClusterDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsBdsInstancesBdsInstancesClusterDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstancesBdsInstancesClusterDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ambariUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmbariUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bdaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bdCellVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdCellVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bdmVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdmVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bdsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bigDataManagerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BigDataManagerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clouderaManagerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClouderaManagerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csqlCellVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsqlCellVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hueServerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HueServerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jupyterHubUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JupyterHubUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "odhVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OdhVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeRefreshed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRefreshed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstances.DataOciBdsBdsInstancesBdsInstancesClusterDetails\"}", isOptional: true)]
        public virtual oci.DataOciBdsBdsInstances.IDataOciBdsBdsInstancesBdsInstancesClusterDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstances.IDataOciBdsBdsInstancesBdsInstancesClusterDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
