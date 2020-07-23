using OneOf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AntDesign.Charts
{
    public class HeatmapConfig : IHeatmapLayerConfig, IPlotConfig
    {
        [JsonPropertyName("sizeField")]
        public string SizeField { get; set; }
        [JsonPropertyName("colorField")]
        public string ColorField { get; set; }
        [JsonPropertyName("shapeSize")]
        public int[] ShapeSize { get; set; }
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }
        [JsonPropertyName("shapeStyle")]
        public GraphicStyle ShapeStyle { get; set; }
        [JsonPropertyName("color")]
        public string[] Color { get; set; }
        [JsonPropertyName("legend")]
        public MatrixLegendConfig Legend { get; set; }
        [JsonPropertyName("renderer")]
        public string Renderer { get; set; }
        [JsonPropertyName("data")]
        public object Data { get; set; }
        [JsonPropertyName("meta")]
        public object Meta { get; set; }
        [JsonPropertyName("padding")]
        public string Padding { get; set; }
        [JsonPropertyName("xField")]
        public string XField { get; set; }
        [JsonPropertyName("yField")]
        public string YField { get; set; }
        [JsonPropertyName("xAxis")]
        public Axis XAxis { get; set; }
        [JsonPropertyName("yAxis")]
        public Axis YAxis { get; set; }
        [JsonPropertyName("label")]
        public Label Label { get; set; }
        [JsonPropertyName("tooltip")]
        public Tooltip Tooltip { get; set; }
        [JsonPropertyName("animation")]
        public object Animation { get; set; }
        [JsonIgnore]
        public OneOf<string, object> Theme { get; set; }
        [JsonPropertyName("theme")]
        public object themeMapping => Theme.Value;
        [JsonPropertyName("responsiveTheme")]
        public object ResponsiveTheme { get; set; }
        [JsonPropertyName("interactions")]
        public Interaction[] Interactions { get; set; }
        [JsonPropertyName("responsive")]
        public bool? Responsive { get; set; }
        [JsonPropertyName("title")]
        public Title Title { get; set; }
        [JsonPropertyName("description")]
        public Description Description { get; set; }
        [JsonPropertyName("guideLine")]
        public GuideLineConfig[] GuideLine { get; set; }
        [JsonPropertyName("defaultState")]
        public ViewConfigDefaultState DefaultState { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("x")]
        public int? X { get; set; }
        [JsonPropertyName("y")]
        public int? Y { get; set; }
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        [JsonPropertyName("parent")]
        public object Parent { get; set; }
        [JsonPropertyName("canvas")]
        public object Canvas { get; set; }
        [JsonPropertyName("forceFit")]
        public bool? ForceFit { get; set; }
        [JsonPropertyName("pixelRatio")]
        public int? PixelRatio { get; set; }
        [JsonPropertyName("localRefresh")]
        public bool? LocalRefresh { get; set; }
        Legend IViewConfig.Legend { get; set; }
    }

    public interface IHeatmapLayerConfig : IHeatmapViewConfig, ILayerConfig { }

    public interface IHeatmapViewConfig : IViewConfig
    {
        [JsonPropertyName("sizeField")]
        public string SizeField { get; set; }
        [JsonPropertyName("colorField")]
        public string ColorField { get; set; }
        [JsonPropertyName("shapeSize")]
        public int[] ShapeSize { get; set; }//number[]
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }
        [JsonPropertyName("shapeStyle")]
        public GraphicStyle ShapeStyle { get; set; }
        [JsonPropertyName("color")]
        public string[] Color { get; set; }
        [JsonPropertyName("legend")]
        public MatrixLegendConfig Legend { get; set; }
    }

    public interface IMatrixLegendConfig
    {
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
        /// <summary>
        /// export type LegendPosition =
        ///    | 'left-top'  | 'left-center'  | 'left-bottom'  | 'right-top'  | 'right-center'  | 'right-bottom'  | 'top-left'  | 'top-center'  | 'top-right'  | 'bottom-left'  | 'bottom-center'  | 'bottom-right';
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; }
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        [JsonPropertyName("text")]
        public MatrixLegendConfigText Text { get; set; }
        [JsonPropertyName("ticklineStyle")]
        public LineStyle TicklineStyle { get; set; }
        [JsonPropertyName("anchorStyle")]
        public GraphicStyle AnchorStyle { get; set; }
        [JsonPropertyName("triggerOn")]
        public string TriggerOn { get; set; }
    }


    public class MatrixLegendConfigText
    {
        [JsonPropertyName("style")]
        public TextStyle Style { get; set; }
        //public () => string formatter { get; set; }
    }

    public class MatrixLegendConfig : IMatrixLegendConfig
    {
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
        [JsonPropertyName("position")]
        public string Position { get; set; }
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        [JsonPropertyName("text")]
        public MatrixLegendConfigText Text { get; set; }
        [JsonPropertyName("ticklineStyle")]
        public LineStyle TicklineStyle { get; set; }
        [JsonPropertyName("anchorStyle")]
        public GraphicStyle AnchorStyle { get; set; }
        [JsonPropertyName("triggerOn")]
        public string TriggerOn { get; set; }
    }
}


