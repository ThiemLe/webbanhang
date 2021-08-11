/**
 * @license Copyright (c) 2003-2021, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';

	config.extraPlugins = 'syntaxhighlight';
	config.syntaxhighlight_lang = 'csharp';
	config.syntaxhighlight_hideControls = true;
	config.language = 'vi';
	config.filebrowserBrowseUrl = '/Scripts/Plugins/ckfinder/ckfinder.html';
	config.filebrowserImageBrowseUrl = '/Asset/Admin/js/ckfinder/ckfinder.html?Type=Images';
	config.filebrowserFlashBrowseUrl = '/Asset/Admin/js/ckfinder/ckfinder.html?Type=Flash';
	config.filebrowserUploadUrl = '/Asset/Admin/js/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
	config.filebrowserImageUploadUrl = '/Data';
	config.filebrowserFlashUploadUrl = '/Asset/Admin/js/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash'
};
