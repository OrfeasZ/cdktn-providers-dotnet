using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDesktopsDesktopPoolDesktops
{
    [JsiiClass(nativeType: typeof(oci.DataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionOutputReference), fullyQualifiedName: "oci.dataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientPlatform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientPlatform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAction", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionLastActionList\"}")]
        public virtual oci.DataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionLastActionList LastAction
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionLastActionList>()!;
        }

        [JsiiProperty(name: "nextAction", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionNextActionList\"}")]
        public virtual oci.DataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionNextActionList NextAction
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnectionNextActionList>()!;
        }

        [JsiiProperty(name: "timeConnected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConnected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDisconnected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDisconnected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDesktopsDesktopPoolDesktops.DataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnection\"}", isOptional: true)]
        public virtual oci.DataOciDesktopsDesktopPoolDesktops.IDataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDesktopsDesktopPoolDesktops.IDataOciDesktopsDesktopPoolDesktopsDesktopPoolDesktopCollectionItemsDesktopConnection?>();
            set => SetInstanceProperty(value);
        }
    }
}
