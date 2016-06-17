var webpack = require("webpack");

module.exports = {
    entry: {
        "vendor": "./wwwroot/app/vendor.ts",
        "app": "./wwwroot/app/main.ts",
    },
    output: {
        path: __dirname + '/wwwroot',
        filename: "./lib/js/[name].bundle.js"
    },
    resolve: {
        extensions: ['', '.js', '.ts']
    },
    module:{
        loaders: [
            {test: /\.ts/, loaders: ['ts-loader'], exclude: /node_modules/}
        ]
    },
    plugins: [
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery"
        }),
        new webpack.optimize.CommonsChunkPlugin(/* chunkName= */"vendor", /* filename= */"./lib/js/vendor.bundle.js")
    ]
}