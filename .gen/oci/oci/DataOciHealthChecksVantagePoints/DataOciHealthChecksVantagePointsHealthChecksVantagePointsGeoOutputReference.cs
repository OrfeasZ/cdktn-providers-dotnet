using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciHealthChecksVantagePoints
{
    [JsiiClass(nativeType: typeof(oci.DataOciHealthChecksVantagePoints.DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeoOutputReference), fullyQualifiedName: "oci.dataOciHealthChecksVantagePoints.DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminDivCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminDivCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountryCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "countryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "geoKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Latitude
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Longitude
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciHealthChecksVantagePoints.DataOciHealthChecksVantagePointsHealthChecksVantagePointsGeo\"}", isOptional: true)]
        public virtual oci.DataOciHealthChecksVantagePoints.IDataOciHealthChecksVantagePointsHealthChecksVantagePointsGeo? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciHealthChecksVantagePoints.IDataOciHealthChecksVantagePointsHealthChecksVantagePointsGeo?>();
            set => SetInstanceProperty(value);
        }
    }
}
